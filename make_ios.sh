mkdir -p build_ios && cd build_ios
cmake -DCMAKE_TOOLCHAIN_FILE=../cmake/iOS.cmake  -GXcode ../
cd ..
cmake --build build_ios --config Release
mkdir -p Plugins/iOS/
cp build_ios/Release-iphoneos/libkcp.a Plugins/iOS/libkcp.a 
rm -rf build_ios
