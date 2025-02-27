# Assignment 1 - Classes and Inheritance
**Team Members: Rocky McGoey, J.R. Muri**<br>
**Github Url:** https://github.com/Jules-Ruby-Dev/oop2-classes-inheritance

## Appliance Details - Notes/Considerations

**Data Formatting - Instructions:**
- Each of the following appliance types is represented differently in the supplied appliances.txt file. 
- Each line in the file represents a different appliance and each piece of information for an appliance is separated by a semi-colon. 
- The first digit of the Item Number indicates the type of the appliance. Each item number is 9 digits long.

**Data Formatting - Notes:**
- *appliances.txt* is semi-colon delimited, so keep that in mind when running .Split() on data
- Since the first digit of the ID indicates the appliance category. We should consider how to handle the evaluation of this. Possibly compare the first char of the string against a build Dictionary keyed with numbers and valued with the respective appliance category.
  - Think:
	```C#
	 	// first index of data from split line, first index of that value (ie the first character of the ID)
	 	char categoryIdentifier = fileLine[0][0]
	  
		Dictionary<string, `category`> // `category` being replaced with type, enum is safe but string works also
		{
			'0': enum.Refrigerator, // bit more initial work, but better practice
	 		'1': enum.Whatever,
	 		// OR..
	 		'0': 'Refrigerator', // might be a bit less setup, but worse... but also this is an assignment, not a career
	 		'1': 'Whatever',
	 
		}
	  
	   // then method to find key that == categoryIdentifier
	```

**Refrigeratores - Instructions:**
- The first digit of the Item Number for refrigerators is 1. 
- Refrigerators have an Item Number, Brand, Quantity, Wattage, Color, Price, Number of Doors, Height and Width (in inches). 
- The number of doors value can be either 2 (double doors), 3 (three doors) or 4 (four doors).
- Each refrigerator is represented in the appliances.txt file file as follows:<br>
	ItemNumber;Brand;Quantity;Wattage;Color;Price;NumberOfDoors;Height;Width<br>
	**Example:**<br>
	089360200;Bosch;176;60;black;2000;2;62;29;

**Refrigeratores - Notes:**
- No immediately apparent notes to make

**Vacuums - Instructions:**
- The first digit of the Item Number for vacuums is 2. 
- Vacuums have an Item Number, Brand, Quantity, Wattage, Color, Price, Grade and Battery Voltage. 
- The Battery voltage value can be either 18 V (Low) or 24 V (High).
- Each vacuum is represented in the appliances.txt file as follows:<br>
	ItemNumber;Brand;Quantity;Wattage;Color;Price;Grade;BatteryVoltage<br>
	**Example:**<br>
	263788832;Hoover;59;600;black;750;Residential;18;

**Vacuums - Notes:**

**Microwaves - Instructions:**
- The first digit of the Item Number for microwaves is 3. 
- Microwaves have an Item Number, Brand, Quantity, Wattage, Color, Price, Capacity and Room Type. 
- The room type is where the microwave will be installed, and is either K (kitchen) or W (work site)
- Each microwave is represented in the appliances.txt file as follows:<br>
    ItemNumber;Brand;Quantity;Wattage;Color;Price;Capacity;RoomType<br>
	**Example:**<br>
	383477937;Miele;201;2350;white;179.9;1.8;Kitchen;


**Microwaves - Notes:**
- No immediately apparent notes to make

**Dishwashers - Instructions:**
- The first digit of the Item Number for dishwashers is 4 or 5. 
- Dishwashers have an Item Number, Brand, Quantity, Wattage, Color, Price, Sound Rating, and Feature. 
- The Sound Rating of the dishwasher can be Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate).
- Each dishwasher is represented in the appliances.txt file as follows:<br>
  ItemNumber;Brand;Quantity;Wattage;Color;Price;Feature;SoundRating<br>
  **Example:**<br>			
  587065284;Kenwood;74;1010;silver;390;Clean with Steam;Qu; 


**Dishwashers - Notes:**
- No immediately apparent notes to make


## Program Guidelines - Notes/Considerations

I'm sleepy, bedtime nao


