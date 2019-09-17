param(
    # Solution Name
    [Parameter(mandatory)]
    [string]
    $SolutionName
)

$SolutionTestName = "$SolutionName.Tests"

# Create Solution
New-Item -Name  "$SolutionName" -Type Directory
Push-Location $SolutionName
dotnet new classlib

# Add to sln file
Pop-Location
dotnet sln add ./$SolutionName/$SolutionName.csproj

# Add Test for Solution
New-Item -Name "$SolutioNTestName" -Type Directory
Push-Location $SolutioNTestName
dotnet new xunit
dotnet add reference ../$Solution/$Solution.csproj

# Add to sln file
Pop-Location
dotnet sln add ./$SolutionTestName/$SolutionTestName.csproj