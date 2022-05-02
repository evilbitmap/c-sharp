# Elections scrapper

Tenhle program je využíván k extrahování výsledků z parlamentních voleb ze stránky kterou najdete [ZDE](https://volby.cz/).

## Spuštění programu
### Instalace knihoven
Veškeré knihovny a jejich verzce jsou uložená v souboru pod jménem ```requirements.txt```. Pro instalaci knihoven spustě
```$ pip install -r requirements.txt```
### Argumenty
Program vyžaduje dva (2) argumenty
1. První argument: Validní URL adresu (např. "https://volby.cz/pls/ps2017nss/ps32?xjazyk=CZ&xkraj=8&xnumnuts=5202")
2. Druhý argument: Výstupní soubor (např. "vystup.csv")
### Ukázka
```python main.py "https://volby.cz/pls/ps2017nss/ps32?xjazyk=CZ&xkraj=8&xnumnuts=5202" "vystup.csv"```

