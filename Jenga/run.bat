IF  "%1"=="1" ( 
    dotnet build "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case1Tests"
)

IF  "%1"=="2" ( 
    dotnet build "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case2Tests"
)

IF  "%1"=="3" ( 
    dotnet build "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\Jenga\Jenga.csproj"
    cd "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga\JengaTests"
    dotnet test --filter "FullyQualifiedName=JengaTests.Case3Tests"
)

IF "%1"=="0" (
    cd "C:\Users\Gladkov_ES\RiderProjects\AlgorithmJenga"
    git reset --hard
)
