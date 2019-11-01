# Save-In... Companion
An unofficial companion program for browser extension [Save In...](https://github.com/gyng/save-in)

# About
This program provides a GUI solution to easily organize your folders in various ways to help create the quick save context menu you desire, in conjunction with the browser extension Save In...

* Includes an easy to read treeview control and understandable buttons for adding and rearranging folders, subfolders, categories and menu separators. 
* Auto subfolder adding options and customizations for fast menu building to your preferences.
* Edit and rename entries, including all subfolders.
* Automatically create the necessary junction/symlinks created inside a(n optionally) system hidden folder within your Downloads folder.
* Creates a formated list that you can copy and paste right into the Save In... Downloads field and your menu is all set!
* Saves yours setup for easy future tweaking.

# Requirements
This software was written with .NET 4.5 and higher for compatible Windows OS. It can also runs in Linux with Mono and possibly other nix systems. The Save In... extension and a compatible browser would also be useful.

# Notes
* Save In... does not support dotfiles, this program does not currently catch them or issue a warning.
* Warning and error feedback are limited on a whole, as of now.
* Linux and any OtherOS should be considered supported on an experimental. I do not have a Mac to test with.
* I am far from a Winforms expert. Running the program in Mono may not be very pretty but I think it will get the job done.
* The initial Downloads folder is chosen on the most common assumptions, if it is not the Downloads folder that your browser and their webextensions have access to, you will need to change it manually in the settings tab. Please check it to be sure.
* When running with normal privlidges in Windows, the program will create junctions rather than symlinks. When running as administrator, symlinks will be made instead. Symlinks will not override junctions already made. *There is no such difference when running the program as root or other evaluated privlidges for other operating systems.* If you do not know the difference, it is probably not important and junctions will be fine enough, if not preferable.
* Code is very much in thrown together mode. This program was made for myself, before I decided to expand on it for others. It works and I think I have squashed out the bugs but it is mess to look at right now.

# Future considerations
* Better documentation.
* More feedback for errors and warnings.
* Polish the UI.
* Organize and comment code.
 
# Legal
This software is provided AS-IS and without warranty. Use at your own risk but there really isn't much going on here that could do too much damage, I don't believe. 

This software and its author is no way associated with Save In... or its authors. Usage of the name "Save In..." is inteded strictly as descriptive.
