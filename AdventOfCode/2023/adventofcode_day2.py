values = []


print("Enter values. Press Enter on an empty line to finish.")

while True:
    value = input("Enter a value (or press Enter to finish): ")
    if value == "":
        break 
    values.append(value)

    
def gameFunc():
    redCubes = 12
    greenCubes = 13
    blueCubes = 14
    gameIDSum = 0
    for val in values:
        isWorking = True
        cleanSplit = val.replace(":", ",")
        spacesremoved = cleanSplit.replace(", ", ",")
        spacesremoved = spacesremoved.replace("; ", ";")
        
        spacesremoved = spacesremoved.split(";")
        gameID = spacesremoved[0]
        listLength = len(spacesremoved)
        firstvalues = spacesremoved[0]
        firstValuesList = firstvalues.split(",")
        for i in range (0, len(spacesremoved)):
            blueCount = 0
            redCount = 0
            greenCount = 0
            insidelist = spacesremoved[i]
            insidelist = insidelist.split(",")
            for x in range (0, len(insidelist)):
                if("blue" in insidelist[x]):
                    blueString = insidelist[x]
                    blueNoSpace = blueString.split(" ")
                    blueValue = blueNoSpace[0]
                    blueCount+=int(blueValue)
                
                if("green" in insidelist[x]):
                    greenString = insidelist[x]
                    greenNoSpace = greenString.split(" ")
                    greenValue = greenNoSpace[0]
                    greenCount+=int(greenValue)
                
                if("red" in insidelist[x]):
                    redString = insidelist[x]
                    redNoSpace = redString.split(" ")
                    redValue = redNoSpace[0]
                    redCount+=int(redValue)
            #print("The blue values this round was: " + str(blueCount) + ", The red was: " + str(redCount) + ", The Green was: " + str(greenCount))
            
            if(greenCount > greenCubes or redCount > redCubes or blueCount > blueCubes):
                isWorking = False

                
                
        if(isWorking):
            idlist = gameID.split(",")
            gameIDVal = idlist[0]
            idlistv2 = gameIDVal.split(" ")
            gameIDVal = idlistv2[1] 
            gameIDSum+=int(gameIDVal)
                
            
    print(gameIDSum)
            
    
        
gameFunc()
            

# Game 1: 1 blue, 1 red; 10 red; 8 red, 1 blue, 1 green; 1 green, 5 blue

                 
        

