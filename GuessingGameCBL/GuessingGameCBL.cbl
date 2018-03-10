      ******************************************************************
      * Author:Gary Cole
      * Date:3/10/2018
      * Purpose: Playing with Cobol
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. GuessingGameCBL.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       01 TRIES PIC 99999 VALUE 0.
       01 LOWERNUM PIC 99999 VALUE 1.
       01 UPPERNUM PIC 99999.
       01 TARGET PIC 99999.
       01 GUESS PIC 99999.
       01 CHOICE PIC X(1) VALUE 'Y'.
       PROCEDURE DIVISION.
       100-MAIN-PROCEDURE.
           SET TRIES TO 0.
            PERFORM 110-GETUPPER.
            COMPUTE TARGET = FUNCTION RANDOM * UPPERNUM + LOWERNUM.
            COMPUTE GUESS = TARGET + LOWERNUM.
            PERFORM 400-PERFOMPROCESS.
            STOP RUN.
       110-GETUPPER.
             DISPLAY "ENTER UPPER LIMIT FOR NUMER".
            ACCEPT UPPERNUM.
       110-END.
       200-GETGUESS.
           DISPLAY "ENTER YOUR GUESS:".
           ACCEPT GUESS.
       200-END.
       300-PROCESSGUESS.
           IF GUESS < TARGET THEN
             DISPLAY "THAT NUMBER IS TOO LOW. TRY AGAIN"
             GO TO 400-PERFOMPROCESS
           ELSE IF GUESS > TARGET THEN
              DISPLAY "THAT NUMBER IS TOO HIGH. TRY AGAIN"
              GO TO 400-PERFOMPROCESS
           ELSE
              DISPLAY "THAT'S IT. YOU GUESSED MY NUMBER.".
              GO TO 500-RESULTS.
       300-END.
       400-PERFOMPROCESS.
            ADD 1 TO TRIES.
            PERFORM 200-GETGUESS.
            PERFORM 300-PROCESSGUESS.
       400-END.
       500-RESULTS.
            DISPLAY "IT ONLY TOOK YOU ", TRIES.
            DISPLAY "TRIES TO GET THE NUMBER.".
            DISPLAY "DO YOU WANT TO PLAY AGAIN(Y/N)?".
            ACCEPT CHOICE.
            MOVE FUNCTION Upper-case(CHOICE) to CHOICE.
            IF CHOICE = "Y" THEN
               GO TO 100-MAIN-PROCEDURE
            ELSE
               GO TO 600-GOODBYE.
       500-END.
       600-GOODBYE.
           DISPLAY "GOOD BYE.".
       600-END.
       END PROGRAM GuessingGameCBL.
