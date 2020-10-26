# BlockRunnerAI Workshop

## Steps + Folder Structure Visualization
![Steps Visualization](https://i.paste.pics/e68880182cc8971e44e3c4231a78f65c.png)

## Step 1: Unity Setup

* Unity Hub
  * Go to: https://unity3d.com/get-unity/download
  * Download Unity Hub
  * Run the Unity Hub Setup file
* License
  * After setup is complete and Unity Hub is open, you should see this at the bottom of the window:
  ![Unity Hub Menu](https://i.paste.pics/fcbee8923b6678a27448515de12622be.png)
  * Click “Manage License”
  * Click “Login”
  * Click “Sign in with google”
  * Click “Activate New License”
  * Select “Unity Personal” + "I don't use Unity in a professional capacity."
* Installing Unity
  * Navigate to “Installs” within Unity Hub
  * Click “Add” and select the first version of Unity shown under "Official Releases" (download might take a while)

## Step 2: Create Folder Named "workshop3"
* Create a folder named "workshop3" somewhere. This will be used to keep the workshop files organized

## Step 3: Download GitHub Repo

* Press the green "Code" button and click "Download ZIP" on this GitHub Repo
* Create a folder named "BlockRunnerAI" inside your "workshop3" folder
* Extract the contents of the ZIP file and drag all the files into the "BlockRunnerAI" folder
* When you look inside the "BlockRunnerAI" folder, you should see: Assets, Library, etc.

## Step 4: Download Python 3.7.9

* Create a folder named "Python" inside the "workshop3" folder and store your Python download in it

### Windows
* Go to: https://www.python.org/downloads/windows/
* Scroll down until you see Python 3.7.9
* Click on "Windows x86-64 executable installer"
 
### Mac OSX / Linux
* This step is unnecessary for Mac users. Proceed to Step 5.
 
 
## Step 5: Create the Virtual Environment

* Open a Terminal (OSX/LINUX) or CMD (WINDOWS) and follow the below instructions

* Change directories to "workshop3" folder
```
cd /path/to/workshop3/
```

### Mac OSX / Linux

* Install virtual environment tool:
```
pip3 install virtualenv
```

* Create and activate virtual environment + Install mlagents Python package:
```
python3.7 -m venv blockrunnerenv

source blockrunnerenv/bin/activate

pip3 install mlagents
```

### Windows

* Install virtual environment tool:
```
pip3 install --user virtualenv
```

* Create and activate virtual environment + Install mlagents Python package:
```
virtualenv --python=D:\workshop3\Python\python.exe blockrunnerenv

blockrunnerenv\Scripts\activate.bat

pip3 install mlagents
```

## Step 6: Open Project Files and Begin Watching YouTube Video
* Open Unity Hub and navigate to the "Projects" section
* Press "Add" and select the folder containing the project files (should be the "BlockRunnerAI" folder inside the "workshop3" folder)
* You are ready to begin watching the video!
