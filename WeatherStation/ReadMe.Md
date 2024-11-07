#WeatherStation

- The first task is to get the weatherstation ID and metadata from ghcnd-stations.txt 
	- Input "Search String" ro "City, State-Abbreviation"
	- For any simple partial matches (aka string.includes): Output "Station ID, Latitude, Longitude, Elevation, State, Name, GSN Flag, HCN/CRN Flag, WMO ID" 
		- Each item should be a separate property in a class. 
	- I've scaffolded some of the code for you, but you'll need to fill in the rest, ... no training wheels.
- Add the ability to search full state names as well as abbreviations