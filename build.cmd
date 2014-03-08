msbuild /t:Clean
msbuild /t:OfficialBuild libraries.msbuild
copy binaries\unsigned\*.dll binaries
copy binaries\net40\unsigned\*.dll binaries\net40
msbuild /t:BuildPackages libraries.msbuild