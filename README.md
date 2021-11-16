# Backend Test CNT
## Enter the "General" directory to be able to build the image
```cd General```
## Build the image
```docker build -t testcnt .```
## Run the image
```docker run -d -p 80:80 testcnt```
## Note
```Verify the credentials to access in the file emergencies_cnt_backend/General/Startup.cs ```
