1. The database first approach was done, so i add the backup and mdf file of the SQL databsse under CroweHW\HWDomain\DataBackup, so you can use this an attach to your local instance for testing as you please
2. Inorder to get this solution running, you will have to open 2 VS2019 instance of the same solution, make one run the API that will use IIS Express, and the other to run the console app
3. You can try out the unit test project also, via the test explorer, just to check things are working as plan (few values have been changed, so they all might not pass currently)
4. In the event there is a refernce issue, reload of the packages can happen or just reference from the system namespace can be done.
5. This solution is just to show the basic fundamentals of current environment, and how to have things integrated and talking to each other in a seemless manner.
