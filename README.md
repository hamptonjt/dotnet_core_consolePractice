# dotnet_core_consolePractice
Learning dotnet core - this is just a small console application - or set of applications

# 100 Days of Code Challenge
This is part of the 100 Days of Code challenge.  I'm wanting to learn .net core, so I'm working from the 
beginning with some console applications and will work my way up to some complex web applications.

# Day 1
Got a small program up and running that prints shapes.  Simple little program utilizing for loops and taking input from the user.
- TODO: add command line arguments to simplify allow the user the ability to do everything in one command rather than interacting
with the program.

# Day 2
Refactored out the printing to it's own class.  Added a command line parameter for the shape.  
- TODO: Add a 'help' command line argument that will display all the options available.

# Day 3
Changed the program to now utilize the command-line fully with a 'help' option.
```
$ dotnet run -- -h
Usage:  [options]

Options:
  -?|-h|--help        Show help information
  -s|--shape <SHAPE>  The Shape - "square", "rect", "triangle" without quotes
  -c|--char <C>       Character used to build shape
  -w|--width <N>      Width of the shape
  -t|--height <N>     Height of the shape
  ```

  There are still obvious holes in this application, but I've learned a lot about how to utilize the command-line using a nuget package.