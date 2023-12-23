values = []
symbols = ["=", "+", "-", "*", "/", "&", "#", "%", "$", "@"]
symbolMemory = {}
numbers = []
seeds = []
location = []
valueToCheck = 0


#print("Enter values. Press Enter on an empty line to finish.")
#
#while True:
#    value = input("Enter a value (or press Enter to finish): ")
#    if value == "":
#        break 
#    values.append(value)


file_path = 'day5.txt'
with open(file_path, 'r') as file:
    lines = file.readlines()


for line in lines:
        addToValues = True
        if(line == lines[0]):
            teststring, seedvalues = line.split(":")
            #test = seedvalues.split(" ")
            seeds = seedvalues.strip().split(" ")
        
for seed in seeds:
    valueToCheck = int(seed)
    for line in lines[2:]:
        addToValues = True
        #mapChecker(valueToCheck,line)
        if(line == "\n"):
            #valueToCheck = mapChecker(valueToCheck)
            for val in range(1, len(values)):
                value = values[val].split(" ")
                maxVal = int(value[1]) + int(value[2])
                if(valueToCheck >= int(value[1]) and valueToCheck < maxVal):
                    print(value[1] + " hittad här")
                    test = valueToCheck - int(value[1])
                    dest = int(value[0]) + test
                    valueToCheck = dest
                    numbers.append(valueToCheck)
                    break


            #location.append(valueToCheck)
            values.clear()
            addToValues = False    
        
        if(addToValues):
            values.append(line.strip())
        
    #valueToCheck = mapChecker(valueToCheck)
    for lastval in range(1, len(values)):
        value = values[lastval].split(" ")
        maxVal = int(value[1]) + int(value[2])
        if(valueToCheck >= int(value[1]) and valueToCheck < maxVal):
            print(value[1] + " hittad här")
            test = valueToCheck - int(value[1])
            dest = int(value[0]) + test
            valueToCheck = dest
            break
    location.append(valueToCheck)
    values.clear()
    addToValues = False    
        
    
    
    
    #values.append(line.strip())

    
    

print(min(location))         


                 
        

