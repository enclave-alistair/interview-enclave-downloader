# Enclave Downloader

We are going to create a console application to download and verify our latest set of Enclave endpoint software for Linux, for each supported processor architecture.
Each version of Enclave has builds for multiple processor architectures; we want to locate the latest version from our hosted manifest file, then download and verify all the tar.gz archives available for that version to the local drive.

This [video of a Docker Pull command](https://asciinema.org/a/310605) demonstrates the user experience we want you to replicate as your application manages the download process.

## Requirements

1.	Download the manifest.
2.	Find the latest "GA" version of the software.
3.	Concurrently download all the available supported architectures of the software at that version.
4.	Track and report against the progress of each download and update the user with progress bars.
5.	Verify the hashes of each file before placing the file in the local directory.
6.	Return a non-zero exit code if any of the files cannot be downloaded, or fail verification.
7.	Wait for all tasks to complete before prompting the user, "Done [Enter to exit]".

## Tips

- The scaffolding in Program.cs is to help you get started.
- We have provided the schema for the manifest file as C# classes.
- Pay attention to your output text, the user should always know what your app is doing.
- Extensive use of Google is encouraged, this is not a knowledge test.
- The code we have provided is not necessarily fault free.

## Example Screenshot

