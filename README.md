# ShiftLights
A simple shift light program for iRacing

With the proper field of view set, it can be difficult to see the rev counter/shift lights in some cars. I experienced this with e.g. the Skippy and the Spec Racer Ford. My solution was to write a small program based on the [iRacingSdkWrapper](https://github.com/NickThissen/iRacingSdkWrapper) that displays revs, gear, and a colored bar.

## Installation

Just place the contents of the bin/Release directory in a location of your choosing. Add a shortcut to your desktop by right-clicking on ShiftLights.exe

iRacing needs to run in window mode, otherwise the ShiftLights window won’t be visible.

## Configuration

The configuration is stored in the text file shiftlights.txt in the program directory. The first line contains four percentage values. At these percentages of the redline rpm in the current gear, the color of the bar changes to green, yellow, orange, and red, respectively. Below the first value, it is blue.

Then follow six lines with the redline rpm for gear one to six.

If you want to use the program with multiple cars that have different redlines, there are two options for doing this:

1. Make a different directory for each car where you place all program files and the respective shiftlights.txt.
2. Create different configuration files (e.g. skippy.txt, srf.txt) and write a small batch program for each car that copies the respective file to shiftlights.txt and then starts the program:

```
copy skippy.txt shiftlights.txt
shiftlights.exe
```
