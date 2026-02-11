# This problem was asked by Google.

# Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s),
# which deserializes the string back into the tree.

# For example, given the following Node class
# class Node:
#     def __init__(self, val, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

# The following test should pass:
# node = Node('root', Node('left', Node('left.left')), Node('right'))
# assert deserialize(serialize(node)).left.left.val == 'left.left'

# Helpful documentation: https://www.geeksforgeeks.org/dsa/serialize-deserialize-binary-tree/

from collections import deque

# Node Structure
class Node:
    def __init__(self, val, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

# Function to serialize the tree
def serialize(root):
    arr = []
    q = deque([root])

    while q:
        curr = q.popleft() # Using the built in function of deque

        if not curr: # If the current node is null, append -1 to result
            arr.append(-1)
            continue

        # Else push its value into the result and push left and right childe nodes into queue
        arr.append(curr.val)
        q.append(curr.left)
        q.append(curr.right)
    
    return arr

# Function to deserialize the tree
def deserialize(arr):
    # Base case, aka empty array
    if arr[0] == -1:
        return None
    
    # Create root node and push it into queue
    root = Node(arr[0])
    q = deque([root])

    i = 1
    while q:
        curr = q.popleft()

        # If left node is not null
        if arr[i] != -1:
            left = Node(arr[i]) # Creating a new node object with the current array position
            curr.left = left # Assigning the current object to the left of the current node
            q.append(left) # Appending the left object to the deque
        i += 1

        # If right node is not null
        if arr[i] != -1:
            right = Node(arr[i])
            curr.right = Node(arr[i])
            q.append(right)
        i += 1
    
    return root

if __name__ == "__main__": # Only run this code when "python3 googleSerializeRoot.py" is executed in the terminal. This code won't run when this file is imported.

    #       10
    #     /    \
    #    20    30
    #  /   \
    # 40  60
    # root = Node(10)
    # root.left = Node(20)
    # root.right = Node(30)
    # root.left.left = Node(40)
    # root.left.right = Node(60)
    
    # arr = serialize(root)
    # res = deserialize(arr)

    # print(arr)
    # print(res)

    node = Node('root', Node('left', Node('left.left')), Node('right'))
    assert deserialize(serialize(node)).left.left.val == 'left.left'