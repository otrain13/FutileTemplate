FutileTemplate
==============

Bash script and template Futile/Unity project to allow for quick Futile project setup.

**Requirements:**

* Mac - This is a bash script built to run on a Mac. I make no claims about it working for anything else.
* Unity 4.2 - The enclosed Unity project is from Unity 4.2. If you're running an earlier version of Unity, you'll need to substitute your own empty Unity project.
* TexturePacker with command line support - The scripts run some TexturePacker commands to build some default atlases.

**How to use this:**

* Clone/download the repo somewhere local.
* Create a new, empty project directly outside the template folder.
* Open a terminal on your Mac.
* Navigate to the repo directory.
* Execute the createfutileproj command, as appropriate (See usage below).
* If everything installed properly, open the project in Unity. Open the MainScene scene file, and drag the Main script and Futile script onto the game object called Futile.
* Run and you should see a pink background, yellow box, with HELLO WORLD in black text.

**Usage:**

    createfutileproj [-c futile_path] [-f futile_path] directory_name
    Note: use one of -c OR -f, not both.

    -c, --clone futile_path
        Clone Futile from github to a location (NOT the project directory) before copying relevant files to the project.

    -f, --futile futile_path
        Use a local copy of Futile. This should point to the root Futile folder in the local repo (the one that contains FutileProject).

    directory_name
        Where you want to create the new project. NOTE: This does not create a new dir, it puts the files IN the directory specified.

**Examples:**

    mkdir ../MyNewGame
    ./createfutileproj -f ../Futile ../MyNewGame

    mkdir ../MyNewGame
    ./createfutileproj -c ../Futile ../MyNewGame

**Notes:**

The script requires that the project directory is already created in case you need to set up git/svn/etc on the project directory first.

**More Stuff:**

This software is released without support or claims that it work for anyone except me. Use it at your own risk. Etc etc etc...
