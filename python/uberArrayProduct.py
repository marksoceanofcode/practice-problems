# This problem was asked by Uber.

# Given an array of integers, return a new array such that each element at index i of the new array
# is the product of all the numbers in the original array except the one at i.
# For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24].
# If our input was [3, 2, 1], the expected output would be [2, 3, 6].

# Follow-up: what if you can't use division? # WDYM???

inputArr = [1, 2, 3, 4, 5] #inputArr = [3, 2, 1]
productArr = [] # Store the product value of each index of inputArr

print("Input:")
print(inputArr)

for a, curNum in enumerate(inputArr): # Iterate through the whole array for each index 
    product = 1 # Keep track of the product total for each index. We can use 1 since 1 * x is x
    for i, num in enumerate(inputArr): # Iterate over the array to multiply all the numbers together
        if(i != a): # Exclude the current index's value from being included in the multiplication
           product *= num
    productArr.append(product) # Add the solved product to the productArr

print("\nOutput:")
print(productArr)
