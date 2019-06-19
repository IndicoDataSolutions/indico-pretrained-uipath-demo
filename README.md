# indico-pretrained-uipath-demo
This is a demo project showing off the use of indico's pretrained api activities for UiPath

### Usage
1. Open up this project in UiPath Studio
2. Make sure the most recent version of the Indico Pretrained package has been loaded.
3. Open a workflow for an activity you wish to demo.
4. Select the root Sequence for the workflow
5. Open the variables tray, and locate the ```apikey``` variable.
6. Replace the "XXX" contents with your personal api key which can be found here: https://app.indico.io/auth/account
7. Press the Run buttom to excute the demo.  The results should show in the Output tray.

### Demos for API endpoints available as activities.
#### Text
* Language
* Organizations
* People
* Places
* Sentiment Analysis
* Text Tags
#### Image
* Content Filtering
* Image Features
#### Document Extraction
* PDF Extraction
* PDF Table Extraction to Excel

### Excel Integration Note
You will need to enable Trust Settings for this demo to run properly. This checkbox will allow the RPA automation to execute macro for merging cells.
In Excel go to File -> Options -> Trust Center -> Macro Settings -> (Check) Trust Access to the VBA project object model.
