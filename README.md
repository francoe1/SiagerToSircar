# SiagerToSircar
Convertidor de datos SIAGER a SIRCAR

# Ejemplos
### Percepciones SIAGER/SIRCAR
```text
161 9999142705401/12/2021F     A000200001818       33545.45  2.00        1006.3600
```
```text
00001,001,A,000200001818,99991427054,01/12/2021,33545.45,2.00,1006.36,011,914
```

### Retenciones SIAGER/SIRCAR
```text
218 9999340939100000000072028/12/202127/12/2021F     A002500011904      147582,71  3,00        4427,4801
```
```text
00001,1,1,002500011904,99993409391,28/12/2021,000147582.71,003.00,000004427.48,011,914
```

Configurar datos desde `conf.ini`

```ini
#COMPROBANTES
C_F=1
C_ND=2
C_R=3
C_NC=102

#Jusrisdicción
TipoRegimenPercepcion=1
JurisdiccionPercepcion=908
TipoRegimenRetencion=1
JurisdiccionRetencion=908
```

# CLI
```cmd
CoreApp.exe -p percepciones.txt
CoreApp.exe -r retenciones.txt
```