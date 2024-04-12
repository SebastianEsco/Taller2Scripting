# Taller2Scripting
-------------
------------------

## Requisitos:
* 1. Equipos diferentes al taller 1.
* 2. Explicar por medio de un ejemplo de mínimo 5 funciones el concepto de delegado.
* 3. Consultar y crear un ejemplo donde se evidencie el uso o de eventos en C# y comparar el modelo de eventos definido en Corgi Engine.

* 4. Consultar que es un Singleton, sus **PROS** y sus **CONTRAS**, como se implementa en C# y en C# en Unity. ¿Dónde se usa este concepto en Corgi Engine?.

* 5. Investigar y explicar **(Diagrama de clases)** un patron de diseño de POO y un principio.

* 6. Consultar y explicar el ciclo de vida de un Script.

* 7. Realizar diasositivas, preparar exposición.

* 8. Usar un repositorio para los ejercicios, mínimo 30 commits, **todos deben participar.**

-------------------
-------------------
## Progreso:
* 1: TERMINADO.
* 2: AVANZADO.
* 3: TERMINADO.
* 4: TERMINADO.
* 5: TERMINADO.
* 6: TERMINADO.
* 7: EN PROGRESO -- Actualizandose.
* 8: TERMINADO.

-------
-------
# Soluciones:
----

## Punto 1
* Santiago Cardenas, Sebastián Escobar y Carlos Santaella
  
## Punto 2
* Pantallazos en Canva, archivo de visual estudio dentro del repositorio.
## Punto 3
* La información está adjunta en la presentación.
## Punto 4
* La información está adjunta en la presentación.
## Punto 5
* La información está adjunta en la presentación.
## Punto 6
* La información también está adjunta en la presentación.
## Initialization ---> Loop (Pyshics,Inputs, Game Logic y Renderings) ---> End of Frame ---> Decommissioning
------
Inicialización:
* Awake: Lo primero que se llama y sólo una vez. Cumple como función revisar antes de que inicie el juego algún error en el script. Se ejecuta aunque el script no se esté usando.
* OnEnable: Sólo ocurre cuando está activo el script. Puede ocurrir en cualquier momento.
* Start: Se activa en el frame que se habilita el script después del awake. Permite accesar las diferentes variables inicializadas y otros scripts.
------
Loop:
* Physics: FixedUpdate. Animaciones. Se calculan Triggers y Colisiones
* Inputs: OnMouses. Interactividad del usuario
* Game Logics: Update (cada frame). Yields (esperar unos segundos). Animaciones. LateUpdate
* Rendering: Renderización de la escena. Renderizado Gizmo. Renderizado de UI
------
Decommissioning:
* Se ejecutan: OnApplicationQuit, OnDisable y OnDestroy.
## Punto 7
* https://www.canva.com/design/DAGBXwTWHBg/yj-uU-1sESsvK8nsUQJu4w/edit?utm_content=DAGBXwTWHBg&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton
## Punto 8
* https://github.com/SebastianEsco/Taller2Scripting

