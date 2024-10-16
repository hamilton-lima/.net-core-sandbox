#!/bin/bash

# GenerateTestReport.sh

# Ensure we're in the HelloWorld.Tests folder
cd "$(dirname "$0")"

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"

# Find the coverage file
coverageFile=$(find . -name "coverage.cobertura.xml" -type f -print -quit)

if [ -n "$coverageFile" ]; then
    # Generate the report
    dotnet tool run reportgenerator -reports:"$coverageFile" -targetdir:"coveragereport" -reporttypes:Html

    # Open the report (this will work on macOS, you might need to modify for Linux)
    if [[ "$OSTYPE" == "darwin"* ]]; then
        open coveragereport/index.html
    elif [[ "$OSTYPE" == "linux-gnu"* ]]; then
        xdg-open coveragereport/index.html
    else
        echo "Report generated at coveragereport/index.html"
    fi
else
    echo "Coverage file not found. Make sure the tests ran successfully."
fi