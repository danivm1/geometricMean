nList = list([])

while True:
    try:
        nList.append(float(input("Insira um numero da serie (ou uma letra qualquer para parar): ")))
    except:
        break

prod = 1
for i in nList:
    prod *= i if i > 0 else -i


geometricMean = prod**(1/len(nList))


print(f"Média Geométrica: {geometricMean}")