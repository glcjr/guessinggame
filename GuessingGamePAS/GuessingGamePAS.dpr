program GuessingGamePAS;
{/*********************************************************************************************************************************
Copyright and Licensing Message
This code is copyright 2018 Gary Cole Jr.
This code is licensed by Gary Cole to others under the GPLv.3 https://opensource.org/licenses/GPL-3.0
If you find the code useful or just feel generous a donation is appreciated.
Donate with this link: paypal.me/GColeJr
Please choose Friends and Family
Alternative Licensing Options
If you prefer to license under the LGPL for a project, https://opensource.org/licenses/LGPL-3.0
Single Developers working on their own project can do so with a donation of $20 or more.
Small and medium companies can do so with a donation of $50 or more.
Corporations can do so with a donation of $1000 or more.
If you prefer to license under the MS-RL for a project, https://opensource.org/licenses/MS-RL
Single Developers working on their own project can do so with a donation of $40 or more.
Small and medium companies can do so with a donation of $100 or more.
Corporations can do so with a donation of $2000 or more.
if you prefer to license under the MS-PL for a project, https://opensource.org/licenses/MS-PL
Single Developers working on their own project can do so with a donation of $1000 or more.
Small and medium companies can do so with a donation of $2000 or more.
Corporations can do so with a donation of $10000 or more.
If you use the code in more than one project, a separate license is required for each project.
Any modifications to this code must retain this message.
*************************************************************************************************************************************/}
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

var
uppernum, guess, target, tries: integer;
ch: char;

function getguess(): integer;
var
guess : integer;
begin
write('Enter your guess: ');
readln(guess);
getguess := guess;
end;

function processguess(target, guess: integer): boolean;

begin
  if (guess < target) then
  begin
    writeln('That guess is too low. Try again.');
    result := false;
  end
  else if (guess > target) then
  begin
    writeln('That guess is too high. Try Agin.');
    result := false;
  end
  else
  begin
    writeln('Thats it! You got my number.');
    result := true;
  end;
  processguess := result;
end;
begin
  try
  Repeat
      writeln('Enter the upper limit for this game');
      readln(uppernum);
      tries := 0;
       randomize;
       target := random(uppernum);
       Repeat
             tries := tries +1;
             guess := getguess();
             if (processguess(target, guess)) then
             begin
               write('It only took you ');
               write(tries);
               writeln(' tries to guess it!');
               write('Want to play again(Y/N)?');
               readln(ch);
             end;
       Until guess = target;
  Until (ch = 'n') or (ch = 'N');
    {
    TODO -oUser -cConsole Main : Insert code here }
  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
