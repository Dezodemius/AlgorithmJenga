IF  "%1"=="1" ( 
    dotnet build "D:\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "D:\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case1Tests"
)

IF  "%1"=="2" ( 
    dotnet build "D:\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "D:\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case2Tests"
)

IF  "%1"=="3" ( 
    dotnet build "D:\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "D:\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case3Tests"
)

IF "%1"=="0" (
    cd "D:\AlgorithmJenga"
    "D:\git\bin\git.exe" reset --hard
)
