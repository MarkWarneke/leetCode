<#
    .SYNOPSIS
    Creates a new class lib based on the solution name
    
    .PARAMETER SolutionName
    Name of the new solution to be created
    
    .EXAMPLE
    ./New-Solution.ps1 -SolutionName "Solution"

#>
param(
    # Solution Name
    [Parameter(mandatory)]
    [string]
    $SolutionName
)

function New-Solution {
    <#
        .SYNOPSIS
        Creates a new class lib based on the solution name
        
        .DESCRIPTION
        Creates a new directory called Soltuion Name,
        initializes a new class lib based on the solution name
        Adds the the new lib to the solution
        Creates a new directory for tests based on solution name
        Initializes new xunit project
        Adds reference to previous created solution
        Adds the new xunit project to solution
        
        .PARAMETER SolutionName
        Name of the new solution to be created
        
        .EXAMPLE
        ./New-Solution.ps1 -SolutionName "Solution"
    #>
    
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
}

New-Solution $SolutionName