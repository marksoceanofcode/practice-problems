# def isInList():
#     return 0

validInput = False
k = 0

while validInput == False:
    userK = input("Enter k(number only): ")
    try:
        k = int(userK)
        validInput = True
    except:
        print("\nError! Value 'k' should be a number.\n")

arr = [10, 15, 3, 7]
nextIndex = 0
kExists = False

for num in arr:
    nextIndex += 1
    if(num < k):
        i = nextIndex
        while i <= (len(arr) - 1):
            #print(num, ", ", arr[i])
            if((num + arr[i]) == k):
                kExists = True
                break
            i += 1
    continue

print(k, "exists:", kExists)
