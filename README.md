# SimplePOS
![preview](https://i.imgur.com/U4z7Uq7.png)
Simple point of sales software built using Windows Form on NET framework.
Read the [docs here (in Bahasa Indonesia)](https://drive.google.com/file/d/1nZN9326ifCXp_2NPJxQNYzk0GpqMCLXG/) and watch the [demo here (Also in Bahasa Indonesia)](https://youtu.be/dJd33bVlmpY).

## Requirements

1. phpMyAdmin

## Setup
1. Start phpMyAdmin and go to http://localhost/phpmyadmin/
2. Create a new database named `simplepos`.
3. Import the [database structure](https://raw.githubusercontent.com/deddyromnan/SimplePOS/master/SimplePOS/database/simplepos.sql) or the [database structure with sample data](https://raw.githubusercontent.com/deddyromnan/SimplePOS/master/SimplePOS/database/simplepos_with_data.sql) to the database.
4. Run the installer. [Download here](https://github.com/deddyromnan/SimplePOS/releases/download/v0.8.1/installer.exe).
5. That's it. Now you can run the app.

PS:

1. If you want to change the database name you have to edit the database name in [App.config](https://github.com/deddyromnan/SimplePOS/blob/master/SimplePOS/App.config).
2. If the app is blurry, go to `SimplePOS\bin\Debug\` right click on `SimplePOS.exe`. Select `Properties>Compatibility>Change high DPI settings>Override high DPI scaling behavior>Application`
