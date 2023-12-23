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


def cardSum():
    pileVal = 0
    for val in values:
        counter = 0
        splitvalues = val.split(":")

        cardVal = splitvalues[1].split(" | ")
        elfCardVal = cardVal[1].split(" ")
        winCardVal = cardVal[0].split(" ")
        elfCardVal = " ".join(elfCardVal).split()
        winCardVal = " ".join(winCardVal).split()
        
        for num in elfCardVal:
            if(num in winCardVal and counter == 0):
                counter +=1
            elif(num in winCardVal):
                counter *=2
        
        pileVal = pileVal + counter
        
                
    print(pileVal)
    
    
    
    
    
    
    
    

                
            
    
        
cardSum()
            


                 
        

