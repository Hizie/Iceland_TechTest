----------------------------
Iceland_TechTest Readme file
----------------------------

Introduction
------------

Writing a program to take expected input including Item Name, SellIn value and Item Quality and to output the same item list based off of a single day passing.

Built as an ASP.Net Web API using an MVC framework. As such the project can either be ran locally or published and hosted for testing / use.

The program runs off passing in a Json object consisting of the required items and will be outputed an object in the same format with the amended values.

Run Instructions
----------------

To run the project specific IDE's can locally host the project without publishing. Alternativly using Windows 10 inbuilt IIS additionally allows for locally hosting web based projects (This would require publishing the application to a local folder and configuring it to the localhost).

To use the application you are required to POST the required Json element to the body of your submission and will need to be able to read the Json object that is returned.

Using the Application
---------------------

Once the application is being hosted you can fire a POST submission using the Json format displayed below to the body of your submission. You will then receive the JsonString back with the corresponding values amended.

	Submission
	----------
	
	URL: https://localhost:[LOCALHOSTID]/api/values/
	Headers:
		Content-Type: application/json
	Body:
		[
			{
				"ItemName": "Aged Brie",
				"ItemValue": 1,
				"ItemQuality": 1
			},
			{
				"ItemName": "Christmas Crackers",
				"ItemValue": -1,
				"ItemQuality": 2
			},
			{
				"ItemName": "Christmas Crackers",
				"ItemValue": 9,
				"ItemQuality": 2
			},
			{
				"ItemName": "Soap",
				"ItemValue": 2,
				"ItemQuality": 2
			},
			{
				"ItemName": "Frozen Item",
				"ItemValue": -1,
				"ItemQuality": 55
			},
			{
				"ItemName": "Frozen Item",
				"ItemValue": 2,
				"ItemQuality": 2
			},
			{
				"ItemName": "INVALID ITEM",
				"ItemValue": 2,
				"ItemQuality": 2
			},
			{
				"ItemName": "Fresh Item",
				"ItemValue": 2,
				"ItemQuality": 2
			},
			{
				"ItemName": "Fresh Item",
				"ItemValue": -1,
				"ItemQuality": 5
			}
		]
		
	Response:
		[
			{
				"ItemName": "Aged Brie",
				"ItemValue": 0,
				"ItemQuality": 2
			},
			{
				"ItemName": "Christmas Crackers",
				"ItemValue": -2,
				"ItemQuality": 0
			},
			{
				"ItemName": "Christmas Crackers",
				"ItemValue": 8,
				"ItemQuality": 4
			},
			{
				"ItemName": "Soap",
				"ItemValue": 2,
				"ItemQuality": 2
			},
			{
				"ItemName": "Frozen Item",
				"ItemValue": -2,
				"ItemQuality": 50
			},
			{
				"ItemName": "Frozen Item",
				"ItemValue": 1,
				"ItemQuality": 1
			},
			{
				"ItemName": "Invalid Item",
				"ItemValue": 0,
				"ItemQuality": 0
			},
			{
				"ItemName": "Fresh Item",
				"ItemValue": 1,
				"ItemQuality": 0
			},
			{
				"ItemName": "Fresh Item",
				"ItemValue": -2,
				"ItemQuality": 1
			}
		]
	
	
