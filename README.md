CS220 - HW5
===

## Build?

Unlike the previous homeworks, you should run `dotnet tool restore` first in
order to build the project.

```sh
dotnet tool restore
dotnet build
```

Also, you can see the results by invoking `dotnet run` at the *root* directory
of the project. When everything goes well, it will start a web server at port
5000. This means, you can open your web browser and navigate to
`http://localhost:5000` to see the result.

## Test?

You can test your implementation by typing `dotnet test`. If you can pass
all the tests, you should be good to commit and push your code.

## Structure

- `Program.fs`: The main entry point of the project.
- `Tests/Tests.fs`: The test suite for the project.
- `HomeworkX.fsproj`: The F# project file for the project, where `X` is the
  homework number.

## Problems

You should read the fsproj file and read the relevant source files to understand
the problems. Typically, we will provide an empty (or partial) implementation
for you to fill in where you can find some comments describing the problem. Of
course, you can also read the relevant test cases to understand the problem.

## Submission

You are given a GitHub classroom link to start the assignment, which will
automatically create a private repository for you. If your repository URL
contains your GitHub username, then you are in the right place. If not, please
get your own private repository from the GitHub classroom link.

You should make modification to your own repository to finish your homework.
Again, your own repository is only visible to you and the course staff. Plus,
your repository URL should contain your GitHub username. You should commit and
push your code to your own repository in order to get a grade.

Whenever you push your code to your repository, the GitHub classroom workflow
will automatically run the test cases and give you a grade based on the test
results. You can check the test results by clicking the "Actions" tab in your
repository page.

If you see a red cross in the "Actions" tab, it means that some of the test
cases are failing. You should check the test results to understand why the test
cases are failing. If you see a green check, it means that all the test cases
are passing, and you should be good to go.

You can always make another commit to fix problems in your implementation, and
push the changes to the repository. The GitHub classroom workflow will
re-evaluate your implementation and update your grade.

## Failure from the Workflow?

Don't panic if you see a red cross in the "Actions" tab. You can always make
another commit to fix problems in your implementation, and push the changes to
the repository. The GitHub classroom workflow will re-evaluate your
implementation and update your grade automatically.

## Auto-Grading?

Auto-grading is performed via the GitHub classroom workflow, which is defined in
`.github/workflows/classroom.yml`. The workflow basically runs `dotnet test` to
test your implementation and then gives you a grade based on the test results.
If you can pass all the tests in your local environment, you should be able to
get a full score.

## Cheating Policy

One may exploit the automatic grading system by hardcoding the expected result
in the test cases --- that is, one can simply add if-then-else statements in the
program to pass all the tests. But, we consider this attempt as cheating.

If we detect any cheating attempt (including but not limited to the one above),
we will immediately give you an F grade for the course, and report the case to
the department.

## Solutions?

There is no single correct solution to the problems. You can always come up with
your own solution as long as it can pass the test cases. If you have any
questions about the problems, feel free to write an issue in the
[main](https://github.com/KAIST-CS220/CS220-Main) repository. But please do
search the existing issues to see if your question has already been answered
before writing a new one.
