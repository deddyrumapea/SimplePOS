# SimplePOS

Simple point of sales software built using Windows Form on NET framework.

## Requirements

1. XAMPP v3.2.4

## Setup

1. Open up your XAMPP control panel.
2. Start MySQL module.
3. Go to http://localhost/phpmyadmin/
4. Create a new database named `simplepos`.
5. Import the [database structure](https://raw.githubusercontent.com/deddyromnan/SimplePOS/master/SimplePOS/database/simplepos.sql) or the [database structure with sample data](https://raw.githubusercontent.com/deddyromnan/SimplePOS/master/SimplePOS/database/simplepos_with_data.sql) to the database.
6. That's it. Now you can run the app.

PS:

1. If you want to change the database name you have to edit the database name in [App.config](https://github.com/deddyromnan/SimplePOS/blob/master/SimplePOS/App.config).
2. If the app is blurry, go to `SimplePOS\bin\Debug\` right click on `SimplePOS.exe`. Select `Properties>Compatibility>Change high DPI settings>Override high DPI scaling behavior>Application`
