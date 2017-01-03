@echo off
@mode con: cols=49 lines=19
@title 实验室拨号上网
@color a
echo.
echo ---------------------注意------------------------
echo 1、南区实验室拨号上网，不用改IP
echo 2、不是实验室别用这个
echo 3、连接成功后不要重复连接，否则宽带连接可能会崩溃
echo -------------------------------------------------
echo 按任意键开始连接...
pause >nul
echo ***>>log.txt
echo %date%%time% >>log.txt
ver >>log.txt
cls
@title 正在登录
echo.
echo -正在连接...
echo.
echo -登录中...
echo. 
echo.
%windir%/system32/rasdial 宽带连接 en1109 1245
whoami >>log.txt
echo %username% Log>>log.txt
echo. >>log.txt
echo.
echo.
echo 稍后自动关闭...
ping 127.1 -n 6 >nul