mkdir build64 & pushd build64
cmake -G "Visual Studio 14 2015 Win64" ..
popd
cmake --build build64 --config Release
md Plugins\x86_64
copy /Y build64\Release\kcp.dll Plugins\x86_64\kcp.dll
rmdir /S /Q build64
pause
