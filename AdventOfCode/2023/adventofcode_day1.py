values = []
numbers = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]


print("Enter values. Press Enter on an empty line to finish.")

while True:
    value = input("Enter a value (or press Enter to finish): ")
    if value == "":
        break 
    values.append(value)

def ValueFind():
    sum = 0
    numberValues = []
    for val in values:
        x = len(val)
        for i in range(0, x):
            if val[i] in numbers:
                firstValue = val[i]
                #print (val[i])
                break
        
        for i in range(0, x):
            if(val[i] in numbers):
                numberValues.append(val[i])
        
        indexOfLast = len(numberValues) -1
        lastValue = numberValues[indexOfLast]
        finalValue = firstValue + lastValue
        print(finalValue)
        sum = sum + int(finalValue)
        numberValues.clear()
    print(sum)

ValueFind()
            



                 
        

