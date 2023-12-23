values = []
symbols = ["=", "+", "-", "*", "/", "&", "#", "%", "$", "@"]
symbolMemory = {}
numbers = []


print("Enter values. Press Enter on an empty line to finish.")

while True:
    value = input("Enter a value (or press Enter to finish): ")
    if value == "":
        break 
    values.append(value)


def partNum():
    sum = 0
    isPartNum = False



    for c in range (len(values)):
        listval = []
        nums=[]
        key = c
        for j in range(len(values[c])):
            if(values[c][j] in symbols):           
                listval.extend([str(j)])
                
        if(len(listval) !=0):
            symbolMemory[key] = listval
    

                
    for key, listval in symbolMemory.items():
        for c in range(key-1, key + 2):
            for j in range(len(values[c])):
                if(values[c][j] not in symbols and values[c][j] != "."):
                    nums.append(values[c][j])
                    for x in range(len(listval)):
                        if (j in range(int(listval[x])-1, int(listval[x])+2) ):
                            isPartNum = True
                else:
                    if(isPartNum):
                        numbers.append("".join(nums))
                        isPartNum = False
                        
                    nums.clear()
                    
    for i in range(len(numbers)):
        sum += int(numbers[i])
    
    numbers.sort()
    print(numbers)
    print(sum)

                
            
    
        
partNum()
            


                 
        

