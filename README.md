# Code42 Code Challenges ReadME
## Running the code
Both Challenge 1 and Challege 2 (InputAnalysis.sln and FileScanner.sln respectively) run on [.NET Core 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1)

To run either or both, clone the repo, and open the .sln file of the desired challenge in Visual Studio. Both of the challenges (with some exceptions) all operate through an API. The API is represented with Swagger. The NuGet package to enable Swagger should be installed on run, but in case they are not, run a package restore. Simply run the solution to open the swagger endpoints, which you can interact with the run the required operations.

**Please note:** when running locally swagger will use a self-signed certificate, you will have to accept this, and when the brower opens, you may be warned about self-signed certs. Just continue through the warning.

## Challenge 1 - Input Analysis
The Input Analysis service does two different things. Per the instructions which required both outputting operations to the console, and "expose a public api", two things happen on runtime. Instead of outputting to the console, the app will read in from the Input.txt file in the "InputFile" directory, and will output the described operations to the Output.txt in the "OutputFile" directory.

It will then launch swagger, which will enable the user to hit endpoints which perform various operations, some outlined in the documentation, some not. the full processed input (sorted into strings, numbers) can be retrieved with the /GetFullProcessedData endpoint.

Input data used by default (included with the repo) is as follows, but can be modified to whatever you desire.

    5
    4.2
    foo
    The quick brown fox
    jumped over the lazy dog.
    foo
    7

Tests can be run from the InputAnalysisTests project, which contains happy path tests for all service methods.

## Challenge 2 - File Scanner
The File Scanner service is more straight forward than the previous. Simply run the project as before to launch the API, which is visualized and interacted with via Swagger (or postman or whatever else you may like, but Swagger is there so it's easiest). The operations will require the input of a full directory path i.e. "C:\Dev\CodeChallenges".

Tests can be run in the FileScannerTests project which again provides happy path tests for all the service methods. **Please note:** that this test project contains a directory within it to be scanned at runtime to ensure consistent results without the use of a mock. 


