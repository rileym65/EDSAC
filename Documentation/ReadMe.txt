EDSAC
Electronic Delay Storage Automatic Calculator

EDSAC was built at the University of Cambridge Mathematical Laboratory and ran
its first programs on May 6, 1949.  EDSAC is considered to be the second stored
program computer and is considered to be the first computer to provide a 
regular computing service.  When originally built EDSAC had a memory capacity
of 512 18-bit words which was later expanded to 1024 words.  EDSAC had a 
punch tape reader for reading in programs and data and a teleprinter for
output.


Character Set
=============
As ASCII had not yet been defined, EDSAC used its encoding.  It should be
noted that on the punched tape there is no difference between the letters and
numbers, for example, Q and 1 are both punched exactly alike and there is no
way to signal to EDSAC whether you intended a Q or a 1.  The teleprinter on
the other hand operated in two modes: letter mode and figure mode.  Depending
on which mode the printer was currently in defined what actually was printed.

Below is the character chart used by EDSAC:

Perforator       Binary   Decimal     Teleprinter
Letter figure                         Letter Figure
P      0         00000    0           P      0
Q      1         00001    1           Q      1
W      2         00010    2           W      2
E      3         00011    3           E      3
R      4         00100    4           R      4
T      5         00101    5           T      5
Y      6         00110    6           Y      6
U      7         00111    7           U      7
I      8         01000    8           I      8
O      9         01001    9           O      9
J                01010    10          J
#                01011    11          Figure shift
S                01100    12          S      "
Z                01101    13          Z      +
K                01110    14          K      (
*                01111    15          Letter shift
.                10000    16
F                10001    17          F      $
@                10010    18          CR
D                10011    19          D      ;
!                10100    20          <space>
H      +         10101    21          H      <LB>
N      -         10110    22          N      ,
M                10111    23          M      .
&                11000    24          LF
L                11001    25          L      )
X                11010    26          X      /
G                11011    27          G      #
A                11100    28          A      -
B                11101    29          B      ?
C                11110    30          C      :
V                11111    31          V      =


Instruction Format
==================
  The instruction format for EDSAC is pretty straightforward.  Each instruction
consisited of the command code, argument address, and a length code.  Most 
instructions got their argument from a memory location which could exist
anywhere within the store.  The length code specified whether the argument data
was single (s) or double (d) precision.  Single precision data was 17 bits
including the sign while double precision data was 35 bits including the sign.

    A 512 S
    | \ / |
    |  |  +- Data length (S or L)
    |  +---- Address (In decimal)
    +------- Command

  If the argument address is zero then it can be ommited, for example if you
wanted the command A 0 S, it could be specified as just A S.

  The tape reader of the simulator ignores any whitespace and therefore white
space may be used in order to make program instructions more readable.  The
simulator reader also ignores anything between square brackets ([]) which 
allows for program comments to be inserted in the code which will be ignored
when the program is read.


Binary Instruction Format
=========================
  The format of an instruction placed in memory is as follows:

    IIIII 0 AAAAAAAAAA L
    \   / | \        / |
     \ /  |  \      /  +- Data length (0=S, 1=L)
      |   |   +----+----- 10-bit Address
      |   +-------------- Not used for instructions
      +------------------ Instruction code


Number Formats
==============
  Single precision uses the following format:

    s vvvvvvvvvvvvvvvv
    | \              /
    |  +------------+--- Value
    +------------------- Sign (0=positive, 1=negative)
 
  Double precision uses the following format:

    s hhhhhhhhhhhhhhhh llllllllllllllllll
    | \              / \                /
    |  \            /   +--------------+---  Low 18 bits of value
    |   +----------+-----------------------  High 16 bits of value
    +--------------------------------------  Sign

  Negative numbers are stored in 2s-compliment.

  When addressing a double precision number the address given in the
instruction must be an even address.  The address in the instruction points
to the low word while the address plus 1 is the high word.


Instruction Set
===============
A n S       A += m[n]            A n L    AB += w[n]
S n S       A -= m[n]            S n L    AB -= w[n]
H n S       R  = m[n]            H n L    RS  = w[n]
V n S       AB += m[n] * R       V n L    ABC += w[n] * RS
N n S       AB -= m[n] * R       N n L    ABC -= w[n] * RS
T n S       m[n] = A, ABC = 0    T n L    w[n] = AB, ABC = 0
U n S       m[n] = A             U n L    w[n] = AB
C n S       AB += m[n] & R       C n L    ABC += w[n] & RS
R n S,R n L Shift ABC right arithmetically
L n S,L n L Shift ABC left arithmetically
E n S       if A >= 0 goto n
G n S       if a < 0 goto n
I n S       readch()->least significant 5 bits of m[n]
O n S       Ouput the character in most significant 5 bits of m[n]
F n S       Verify the last character output
X   S       No Operation
Y   S       Add 1 to bit position 35 of ABC, counting the sign bit as bit zero
Z   S       Stop machine and ring bell


----+----1----+----2----+----3----+----4----+----5----+----6----+----7----+----8

Shift values
============
  Shift instructions work a bit strangely on EDSAC.  The number of shifts is
controlled by where the first 1 bit is counting from the right.  As such the
argument address does not specify an address but rather is used to determine
how far the accumulator is shifted.  This table shows what number is needed
for a given shift count:

    0 L    - 1
    1 S    - 2
    2 S    - 3
    4 S    - 4
    8 S    - 5
   16 S    - 6
   32 S    - 7
   64 S    - 8
  128 S    - 9
  256 S    - 10
  512 S    - 11
 1024 S    - 12


Setting up a wheeler jump (subroutine call/return)
==================================================
  Although EDSAC does not have any commands directly for subroutines, nor is
there a stack, it is possible to use subroutines.  David Wheeler developed
a method for calling subroutines.  This was done by passing the current
address to the subroutine which would then plant a jump to this address as
the last command of the subroutine.    Here is how you setup such a jump:
[Main]
[m  ]  A   m F    | Pick up self
[m+1]  G   n F    | Jump to subroutine
[m+2]             | Control returns here

[Subroutine]
[n  ]  A   3 F    | Form return link
[n+1]  T   p F    | Plant return link
          .
          .
          .
[p  ]     .       | Return link planted here


Initial Orders 1
================
  The initial orders were loaded into EDSAC from hand-set uniselector switches.
The purpose of the initial orders was to read a program from paper tape and
load it into the store.  The first set of initial orders is actually considered
to be the first assembler, as it took the codes punch on the tape and converted
them into the words that are stored into memory.  Initial Orders 1 started
loading a program into memory address 31 and expected this first instruction to
be in the form of T nnnn S, where nnnn was the last address used by the program
plus 1.  This was used to determine where the end of the program tape was, at
this point the initial orders would stop transcribing the paper tape into 
program storage and begin execution at address 31.  Since the instruction at
address 31 was a T command, the result was the program would begin with the
accumulator being cleared.

  All programs which are meant to be loaded by Initial Oders 1 should start
with this line:

[31]    T n S               Where n=last address used +1


Initial Orders 2
================
  It was not long before Initial Orders 1 proved to be too limiting and so 
Initial Orders 2 was created.  This version of the Initial Orders actually 
provided a primitive relocation capability making it easier to incorporate
subroutines into the main program without having to keep exact track of every
location in memory during program creation.  Initial Orders 2 added several
pseudo-ops that controlled how programs were loaded:

        T  m K              Set load point to m
        G    K              Set the delta (@) parameter to current load point
        T    Z              Set load point to @ parameter
        E  m K P F          Enter program at location m
        E    Z P F          Enter program at location @
        P    Z              ???
        P    K              ???

  An important distinction to note when writing programs for use with Initial
Orders 2 is that the length code changed from S to F for short formatted data
and from L to D for long formatted data.  This also makes it fairly easy to
determine which set of Initial Orders needs to be selected to load a given 
program.  If the length code is always S or L, then you load the program with
Initial Orders 1, else if there are F, D, @, or other symbols used as the
length code then program needs to be loaded using Initial Orders 2.

  New end codes usable in Initial Orders 2:
        @ - Add current delta to address field
        ! - Add contents of m[44] to address field
        H - Add contents of m[45] to address field
        N - Add contents of m[46] to address field
        M - Add contents of m[47] to address field
        & - Add contents of m[48] to address field
        L - Add contents of m[49] to address field
        X - Add contents of m[50] to address field
        G - Add contents of m[51] to address field
        A - Add contents of m[52] to address field
        B - Add contents of m[53] to address field
        C - Add contents of m[54] to address field
        V - Add contents of m[55] to address field
        # - Set data lengh flag to D and then allow an additional end code

  Programs should begin above address 55 in order to not conflict with the
Initial Orders 2 code or the addressing variables.  However, by using an
command of T 44 K you can preload values for the ! through V end codes.


Sample programs
===============
Sample program #1 - Read one character from tape and print it (Initial Orders 1)

[31]    T   40 S       [ Needed for IO1 and clear acc ]
[32]    I   64 S       [ Read next from tape into m(64) ]
[33]    A   64 S       [ Load character into acc ]
[34]    L 1024 S       [ Shift to 5 most significant bits ]
[35]    U   64 S       [ Store back into m(64) ]
[36]    O   39 S       [ Output # to set teleprinter to symbol mode ]
[37]    O   64 S       [ Output read character to teleprinter ]
[38]    Z      S       [ End the program ]
[39]    #      S       [ # character constant for symbol mode ]
        6

Sample program #2 - Count from 1 to 9 ( Initial Orders 1)

[31]    T   50 S       [ Needed for IO1 and clear acc ]
[32]    O   44 S       [ Output # to set teleprinter to symbol mode ]
[33]    A   45 S       [ Get next number ]
[34]    L  512 S       [ Shift for output ]
[35]    T   46 S       [ WRite for output and clear acc ]
[36]    O   46 S       [ Send to printer ]
[37]    O   47 S       [ Send carriage return ]
[38]    A   45 S       [ get current number ]
[39]    A   48 S       [ Add 1 to it ]
[40]    U   45 S       [ Store it ]
[41]    S   49 S       [ Need to see if it is 10 yet ]
[42]    G   31 S       [ Loop back if not ]
[43]    Z      S       [ End the program]
[44]    #      S       [ # character constant for symbol mode ]
[45]    P    1 S       [ place for counting ]
[46]    P      S       [ Place to store character for output ]
[47]    &      S       [ Character constant for CR ]
[48]    P    1 S       [ 1 constant ]
[49]    P   10 S       [ 10 constant ]

Sample program #3 - Count from 1 to 9 ( Initial Orders 2)

[64]    T   64 K       [ Set load position ]
[64]    T   63 F       [ Clear the accumulator ]
[65]    O   77 F       [ Output # to set teleprinter to symbol mode ]
[66]    A   78 F       [ Get next number ]
[67]    L  512 F       [ Shift for output ]
[68]    T   79 F       [ WRite for output and clear acc ]
[69]    O   79 F       [ Send to printer ]
[70]    O   80 F       [ Send carriage return ]
[71]    A   78 F       [ get current number ]
[72]    A   81 F       [ Add 1 to it ]
[73]    U   78 F       [ Store it ]
[74]    S   82 F       [ Need to see if it is 10 yet ]
[75]    G   64 F       [ Loop back if not ]
[76]    Z      F       [ End the program]
[77]    #      F       [ # character constant for symbol mode ]
[78]    P    1 F       [ place for counting ]
[79]    P      F       [ Place to store character for output ]
[80]    &      F       [ Character constant for CR ]
[81]    P    1 F       [ 1 constant ]
[82]    P   10 F       [ 10 constant ]
[83]    E   64 K       [ Enter program at 64 ]
[84]    P      F

Sample program #4 - Count from 1 to 9 ( Initial Orders 2)

        T   64 K       [ Set load position ]
        G      K       [ Set delta parameter ]
[0]     T   21 @       [ Clear the accumulator ]
[1]     O   13 @       [ Output # to set teleprinter to symbol mode ]
[2]     A   14 @       [ Get next number ]
[3]     L  512 F       [ Shift for output ]
[4]     T   15 @       [ WRite for output and clear acc ]
[5]     O   15 @       [ Send to printer ]
[6]     O   16 @       [ Send carriage return ]
[7]     A   14 @       [ get current number ]
[8]     A   17 @       [ Add 1 to it ]
[9]     U   14 @       [ Store it ]
[10]    S   18 @       [ Need to see if it is 10 yet ]
[11]    G    0 @       [ Loop back if not ]
[12]    Z      F       [ End the program]
[13]    #      F       [ # character constant for symbol mode ]
[14]    P    1 F       [ place for counting ]
[15]    P      F       [ Place to store character for output ]
[16]    &      F       [ Character constant for CR ]
[17]    P    1 F       [ 1 constant ]
[18]    P   10 F       [ 10 constant ]
[19]    E      Z       [ Enter at delta parameter ]
[20]    P      F

Sample program #5 - Test C function ( Initial Orders 2)
        T   64 K       [ Set load position ]
        G      K       [ Set delta parameter ]
[0]     T   63 F       [ Clear the accumulator ]
[1]     E    4 @       [ jump past data ]
[2]     P    5 F       [ data 5 ]
[3]     P    6 F       [ data 6 ]
[4]     H    2 @       [ Load 5 into R ]
[5]     C    3 @       [ And it with 6 ]
[6]     Z      F       [ End program ]
[7]     E      Z       [ Enter at load point ]
[8]     P      F 

Sample program #6 - Compare two numbers for equal (Initial Orders 2)
        T   64 K       [ Set load position ]
        G      K       [ Set delta parameter ]
[0]     T   63 F       [ Clear accumulator ]
[1]     E    8 @       [ Jump past constants ]
[2]     P    5 F       [ Data 5 ]
[3]     P    6 F       [ Data 6 ]
[4]     Y    0 F       [ Data 'Y' ]
[5]     N    0 F       [ Data 'N' ]
[6]     P    1 F       [ Data 1 ]
[7]     *    0 F       [ Figure shift mode ]
[8]     O    7 @       [ Force figure shift on output ]
[9]     A    2 @       [ SEt accumulator to first value ]
[10]    S    3 @       [ Compare to second value ]
[11]    G   14 @       [ jump if negative resulted ]
[12]    S    6 @       [ If zero, then subtracting 1 will make negative
[13]    G   16 @       [ jump if it really was zero ]
[14]    O    5 @       [ Indicate numbers did not match ]
[15]    Z      F       [ and stop ]
[16]    O    4 @       [ Indicate that numbers did match ]
[17]    Z      F       [ and stop ]
        E      Z
        P      F


Sample program #7 - Print .125
     T   64 K
[ Print 0D fractional number ]
     G      K
[ 0] A    3 F    [ Create return link ]
[ 1] T   17 @    [ Write to return link ]
[ 2] O   18 @    [ Force figure shift mode ]
[ 3] O   19 @    [ write a period ]
[ 4] H   22 @    [ Set multiplier to 10/16
[ 5] S   20 @    [ Get places terminal count ]
[ 6] T   21 @    [ and store it ]
[ 7] V      D    [ Multiply current number by 10/16 ]
[ 8] U      F    [ Store for output ]
[ 9] O      F    [ Print digit ]
[10] F      F    [ Get just printed number ]
[11] S      F    [ Remove printed number ]
[12] L    4 F    [ Shift over 4 places ]
[13] T      D    [ Store current number ]
[14] A   21 @    [ Get places count ]
[15] A   23 @    [ Minus 1 ]
[16] G    6 @    [ Loop back if not done ]
[17] P      F    [ Return link will be written here ]
[18] #      F    [ Figure shift mode ]
[19] M      F    [ Period ]
[20] P    4 F    [ Number of decimal places ]
[21] P      F    [ Place to track count ]
[22] J      F    [ 10 /16 ]
[23] P    1 F    [ 1 ]


Sample program #8 - Read .125 from tape
     T  128 K
     G      K
[ 0] T      D    [ Clear accumulator ]
[ 1] A    6 @    [ load argument ]
[ 2] T      D    [ WRite it out ]
[ 3] A    3 @    [ Pick up return address ]
[ 4] G   64 F    [ Call print subroutine ]
[ 5] Z      F    [ End program ]
[ 6] W      F    [ .125 ]
     E      Z
     P      F
     T   64 K
     G      K    [ Set @ parameter ]
     T   55 k    [ Set to V parameter ]
[55] P   34 @    [ Address of variable block - V0 ]
     T      Z    [ Restore load point ]
[ 0] A    3 F    [ Create return link ]
[ 1] T    0 V    [ Return link is first word in variable block ]
[ 2] T    0 D    [ Clear return value ]
[ 3] A    2 V    [ Get input switch ]
[ 4] T    8 @    [ Write to switch ]
[ 5] H    1 V    [ Set Multiplier ]
[ 6] S    4 V    [ Get digit count ]
[ 7] T    5 V    [ Transfer to character count ]
[ 8] I   12 V    [ Switch, input from tape ]
[ 9] A   12 V    [ Get read character ]
[10] S    4 V    [ See if above numerals ]
[11] E   29 @    [ jump if so ]
[12] T   63 F    [ Clear accumulator ]
[13] V      D    [ Multiply previous digits ]
[14] L    8 F    [ Shift 5 places left ]
[15] A   12 #V   [ Add in new digit ]
[16] T      D    [ Store current results ]
[17] A    5 V    [ Get character count ]
[18] A    7 V    [ increment it ]
[19] G    7 @    [ Loop back if not all read ]
[20] H      D    [ Multiply by 2^34/10^10 ]
[21] N    9 V    [          /   ]
[22] R  128 F    [         /    ]
[23] R  128 F    [        /     ]
[24] V   10 V    [       /      ]
[25] L      D    [      /       ]
[26] Y      F    [     /        ]
[27] T      D    [ Write to return value ]
[28] E      V    [ Return to caller ]
[29] T   63 F    [ Clear accumulator ]
[30] A   11 V    [ Get switch to read in zeroes ]
[31] T    8 @    [ Write to switch ]
[32] E   17 @    [ Back to main loop ]
[33] P      F    [ Filler to make sure V0 is on even address ]
[V0] P      F    [ Space for return link ]
[ 1] T      F    [ 10/32 ]
[ 2] I   12 V    [ Command to read from tape ]
[ 3] P      F    [ Where read characters go ]
[ 4] P    5 D    [ Constant 11 ]
[ 5] P      F    [ Character count ]
[ 6] P    2 D    [ Constant 5 ]
[ 7] P      D    [ Constant 1 ]
[ 8] U    1 F    [ Constant ]
[ 9] P  610 D    [ Constant ]
[10] Z 1523 D    [ Constant ]
[11] T   12 V    [ Switch for remaining zeroes ]
[12] P      F    [ Where to read input character ]
[13] P      F    [ 0 ]

     T  128 K
     G      K
[ 0] A    0 @    [ Prepare for subroutine call ]
[ 1] G   64 F    [ Call input subroutine ]
[ 2] Z      F    [ Stop machine ]
     E      Z
     P      F
[ Data follows ]
125F


Initial Orders 1 Listing:
=========================
05000   00101 0 0000000000 0    0    T    S     Clears accumulator and puts 10/32 in multiplier
15004   10101 0 0000000010 0    1    H  2 S       register
05000   00101 0 0000000000 0    2    T    S     Control switched to 6. Locations 0-3 are then
0300c   00011 0 0000000110 0    3    E  6 S       used as 'working space'
00002   00000 0 0000000001 0    4    P  1 S     2^-15 constant
0000a   00000 0 0000000101 0    5    P  5 S     10*2^-16 constant
05000   00101 0 0000000000 0    6    T    S     \
08000   01000 0 0000000000 0    7    I    S      Input function digits to their correct digital
1c000   11100 0 0000000000 0    8    A    S       position in 0
04020   00100 0 0000010000 0    9    R 16 S      |
05001   00101 0 0000000000 1    10   T    L     /
08004   01000 0 0000000010 0    11   I  2 S    Reads character on the tape and test whether
1c004   11100 0 0000000010 0    12   A  2 S      it is numerically less than 10
0c00a   01100 0 0000000101 0    13   S  5 S     /
0302a   00011 0 0000010101 0    14   E 21 S    /
05006   00101 0 0000000011 0    15   T  3 S    Clears accumulator using 3 as a rubbish dump
1f002   11111 0 0000000001 0    16   V  1 S    One stage of the binary-decimal conversion. New
19010   11001 0 0000001000 0    17   L  8 S      partial address is obtained by taking ten times
1c004   11100 0 0000000010 0    18   A  2 S      old partial address and adding the next digit
05002   00101 0 0000000001 0    19   T  1 S    /
03016   00011 0 0000001011 0    20   E 11 S    Transfers control to location 11
04008   00100 0 0000000100 0    21   R  4 S    Control is transferred to 21 from the order 14
                                                  when character read is S or L.  When L has been
                                                  read the 17th digit of the accumulator is a 1,
                                                  when S has been read it is a 0
1c002   11100 0 0000000001 0    22   A  1 S    The address has been formed x s^-16 and so needs
19001   11001 0 0000000000 1    23   L    L      doubling
1c000   11100 0 0000000000 0    24   A    S    Forms the complete order in the accumulator
0503e   00101 0 0000011111 0    25   T 31 S    Transfers the order to its final position in store
1c032   11100 0 0000011001 0    26   A 25 S    Incresses the address specified in order 25
1c008   11100 0 0000000100 0    27   A  4 S      by 1; eg. T31S is replaced by T32S
07032   00111 0 0000011001 0    28   U 25 S      and so on
0c03e   01100 0 0000011111 0    29   S 31 S    Tests whether all orders have been taken in.
1b00c   11011 0 0000000110 0    30   G  6 S      Location 31 contains orders T (n+1) S, the
                                                 first order ton be placed in the store: and so
                                                 C(Acc) will be positive only when all oderrs
                                                 have been taken into the store


Initial Orders 2 Listing
========================
05000 00101 0 0000000000 0  [ 0]   T    F    These order cause control to be transferred
03028 00011 0 0000010100 0  [ 1]   E 20 F      to 20.  they are not used after the start, but
                                               their locations are used as working space.
00002 00000 0 0000000001 0  [ 2]   P  1 F    These are constants which are intended to be
07004 00111 0 0000000010 0  [ 3]   U  2 F      left here unaltered in any program
1c04e 11100 0 0000100111 0  [ 4]   A 39 F    Input of address.  This group of orders is en-
04008 00100 0 0000000100 0  [ 5]   R  4 F      tered at 8 with the accumulator empty, so
1f000 11111 0 0000000000 0  [ 6]   V    F      that 0 is cleared. The next digit on the tape
19010 11001 0 0000001000 0  [ 7]   L  8 F      is taken in and tested to see if it is less than
05000 00101 0 0000000000 0  [ 8]   T    F      eleven; if so it is doubled and added to ten
08002 01000 0 0000000001 0  [ 9]   I  1 F      times the content of 0, the sum being sent
1c002 11100 0 0000000001 0  [10]   A  1 F      back to 0.  the next digit is read, tested, etc.,
0c04e 01100 0 0000100111 0  [11]   S 39 F      and this is continued until the whole addreess
1b008 11011 0 0000000100 0  [12]   G  4 F      has been formed; the next digit read, x, is
                                               greater than ten and so corresponds to a 
                                               code letter
19001 11001 0 0000000000 1  [13]   L    D    These test to see if x is greater than sixteen.
0c04e 01100 0 0000100111 0  [14]   S 39 F      If it is, the order A(24+x)F is formed and
03022 00011 0 0000010001 0  [15]   E 17 F      planted in 20.  If x is sixteen or less a switch
0c00e 01100 0 0000000111 0  [16]   S  7 F      order E(16+x)F is formed and planted in 20.
1c046 11100 0 0000100011 0  [17]   A 35 F     /
05028 00101 0 0000010100 0  [18]   T 20 F    /
1c000 11100 0 0000000000 0  [19]   A    F    This adds the address, which is always positive,
                                               into the accumulator.
15010 10101 0 0000001000 0  [20]   H  8 F    This order places 10/32 in the multiplier regis-
                                               ter during the start and is later replaced by a
                                               manufactured one which either adds to the
                                               accumulator the number determined by x, or
                                               switches control to an address determined by x.
1c050 11100 0 0000101000 0  [21]   A 40 F    this adds in the function digits of the order so
                                               the accumulator now contains the order from
                                               the tape plus the number selected by x.
05056 00101 0 0000101011 0  [22]   T 43 F    This (the transfer order) transfers the assembled
                                             order to its final place in the store
1c02c 11100 0 0000010110 0  [23]   A 22 F    These orders increase the address specified in
1c004 11100 0 0000000010 0  [24]   A  2 F      the transfer order by unity.
0502c 00101 0 0000010110 0  [25]   T 22 F    /
03044 00011 0 0000100010 0  [26]   E 34 F    Transfers control to 34.
1c056 11100 0 0000101011 0  [27]   A 43 F    Control is switched to these orders by 20 when
03010 00011 0 0000001000 0  [28]   E  8 F      pi has been read from the tape.  They add 2^-16
                                               to the address (which is in the accumulator)
                                               and transfer control to 8.  the address now
                                               refers to a long storage location.
1c054 11100 0 0000101010 0  [29]   A 42 F    This adds the address in 42 to the accumulator
1c050 11100 0 0000101000 0  [30]   A 40 F    This adds the function digits of the order to the
                                               accumulator.  The result is that the number in
                                               the accumulator is positive if the order has
                                               function digits represented by T or E, while
                                               it is negative in the case of G.
03032 00011 0 0000011001 0  [31]   E 25 F    If the accumulator is positive, the order in the
1c02c 11100 0 0000010110 0  [32]   A 22 F      accumulator replaces the order in 22; if nega-
05054 00101 0 0000101010 0  [33]   T 42 F      tive the accumulator contains the address spe-
                                               cified in order 22 which is then put in 42 (the
                                               storage location corresponding to @).
08051 01000 0 0000101000 1  [34]   I 40 D    These take in the function digits, shift them to
1c051 11100 0 0000101000 1  [35]   A 40 D      their correct place and transfer them to 40.
04020 00100 0 0000010000 0  [36]   R 16 F      The order in 35 is also used as a constant.
05051 00101 0 0000101000 1  [37]   T 40 D     /
03010 00011 0 0000001000 0  [38]   E  8 F    /
0000b 00000 0 0000000101 1  [39]   P  5 D    A constant used in the input of the address.  It
                                               equals 11.2^-16
00001 00000 0 0000000000 1  [40]   P    D    A constant used during the start.  It equals 2^-16


