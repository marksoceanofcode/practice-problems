# This problem was asked by Stripe.

# Given an array of integers, find the first missing positive integer in linear time and constant space.
# In other words, find the lowest positive integer that does not exist in the array. The array can contain
# duplicates and negative numbers as well.

# For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.

# You can modify the input array in-place.

lowestNum = 1 # We can safely assume 1 is the default lowest positive integer
#lowestInArr = 0
inputArr = [3, 4, -1, 1]

# Sort the array, list, so we can check in order whats the lowest num
inputArr.sort()

# Step through the array
for num in inputArr:
    if num == lowestNum: # If the lowestNum is the current integer value, then add 1 to the lowestNum value
        lowestNum += 1
    elif num > lowestNum:
        break
    else:
        continue
    
print("The lowest integer:", lowestNum) 