@ECHO OFF
ECHO Demo Automation Executed Started.


set testcategory=OrderTest
set dllpath=C:\Users\asiffkam\source\repos\seleniumQuiz\seleniumQuiz\bin\Debug\seleniumQuiz.dll

set SummaryReportPath=C:\Users\asiffkam\source\repos\seleniumQuiz\seleniumQuiz\TestSummary


call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\filename.trx"

cd C:\Users\asiffkam\source\repos\homeShoppingProject\homeShoppingProject\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE