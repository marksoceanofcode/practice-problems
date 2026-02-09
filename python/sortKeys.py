import json #Import the json library?

#Format key function
def formatKey(key):
    return key.lower().replace(" ", "_") # Really similar to JS

# Sample JSON Data
jsonString = '{"first Name": "Mark", "Last Name": "Ocean of Code", "age": 25, "Address": "123 Main St", "email": "alice@example.com", "jOb Title": "Software Engineer"}'
data = json.loads(jsonString) # Converts the JSON string to a dictionary

# Get the keys
#keys = data.keys()

# Case insensitive sort
#sortedKeys = sorted(data.keys(), key=str.lower) # keys() is a dictionary method that returns all keys

# Short form of this:
#sorted_dict = {}
#for k in sorted_keys:
    #sorted_dict[k] = data[k]
#sortedDict = {k: data[k] for k in sortedKeys} # Wrap in {} to make a dictionary, loop through all the sorted_keys and assign the current key the data of the key, making a new dictionary

# Format all keys
# - data.items() gets key value pairs [("first Name": "Mark"), (...)...]
# - Loop through k = key, v = value
# - formatKey(k): v, format the key but, keep the value the same
#formattedKeys = {formatKey(k): v for k, v in data.items()} # Without sorted keys
#formattedKeys = {formatKey(k): data[k] for k in sortedKeys} # With sorted keys
sortAndFormatKeys = {formatKey(k): data[k] for k in (sorted(data.keys(), key=str.lower))} # With sorting & formatting

print(json.dumps(sortAndFormatKeys, indent=2))

# Learnings
# - Python is dynamically typed, so it knows a string is a string, integer, dictionary(what is an object in JS)
# - To add a type hint do, jsonString: str = '{...}' or data: dict = json.loads(json_string)
# - The opposite of json.loads() is json.dumps() which converts to a string
