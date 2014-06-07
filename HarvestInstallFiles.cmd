@ECHO OFF
ECHO ---------WiX Heat--------------
ECHO Running Heat on Web and Service folder.
SET CURRENTDIR=%~dp0
ECHO.

"%WIX%bin\heat.exe" dir "%CURRENTDIR%FuzhePan.HuobanClient\bin\Release" -dr HuobanClientByFuzhePan -cg HuobanClientFilesGroup -gg -g1 -sf -srd -var "var.HuobanClientSrcDir" -out "%CURRENTDIR%Setup\Setup\HuobanClientFiles.wxs"
ECHO.
ECHO Finished. Output has been saved as 'HuobanClientFiles.wxs'.