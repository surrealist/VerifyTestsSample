# VerifyTests sample

Approval test or Snapshot test is a kind of unit testing
that applying `difftool` into testing nicely.

I had try [ApprovalTests.Net](https://github.com/approvals/ApprovalTests.Net)
and [VerifyTests](https://github.com/VerifyTests/Verify) and found that the later
run more smooth in Visual Studio.

## Steps

```bash
> dotnet test
```

Results

```
  Determining projects to restore...
  All projects are up-to-date for restore.
  VerifySample -> D:\githubs\surrealist\VerifySample\bin\Debug\net5.0\VerifySample.dll
Test run for D:\githubs\surrealist\VerifySample\bin\Debug\net5.0\VerifySample.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 129 ms - VerifySample.dll (net5.0)
```
