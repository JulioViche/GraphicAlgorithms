# Algoritmos Gráficos Básicos

Aplicación interactiva desarrollada en Windows Forms que implementa algoritmos gráficos clásicos como DDA, Bresenham y FloodFill. El proyecto combina la precisión matemática de estos algoritmos con una interfaz moderna y animaciones visuales paso a paso.

## ✨ Características Principales

- Trazado de líneas con DDA y Bresenham
- Trazado de círculos con Bresenham
- Dibujo de rombos a partir de dimensiones
- Relleno por inundación (FloodFill)
- Animaciones visuales del proceso de dibujo
- Cancelación de operaciones en tiempo real
- Interfaz gráfica intuitiva y responsiva

## 🖼️ Interfaz de Usuario

### Canvas

- Área de dibujo fija: 400x400 píxeles
- Click izquierdo: activa herramienta de relleno

### Controles de Dibujo

- Líneas: ingreso manual de coordenadas (x₀, y₀) y (x₁, y₁)
- Círculos: coordenadas del centro (x, y) y radio r
- Rombos: especificación de ancho y alto

### Controles Generales

- Activar o desactivar animaciones
- Cancelar animación actual
- Limpiar completamente el canvas

## 🧮 Algoritmos Implementados

### 1. Digital Differential Analyzer (DDA)

- Trazado mediante incrementos de punto flotante
- Visualización animada paso a paso

### 2. Algoritmo de Bresenham para Líneas

- Uso exclusivo de enteros para mayor rendimiento
- Soporte completo para todas las pendientes

### 3. Bresenham para Círculos

- Trazado eficiente usando simetría por octantes
- Alta precisión en representación circular

### 4. FloodFill

- Relleno por inundación desde un punto semilla
- Optimización para rellenar áreas extensas

## 🧰 Requisitos Técnicos

- Windows Forms (.NET Framework)
- Resolución mínima recomendada: 800x600

## ▶️ Instrucciones de Uso

1. Selecciona el algoritmo gráfico que desees utilizar.
2. Ingresa los parámetros solicitados.
3. (Opcional) Activa la animación para visualizar el proceso.
4. Ejecuta el algoritmo y observa el resultado.
5. Puedes cancelar o limpiar el canvas en cualquier momento.

## ⚠️ Limitaciones
- Área de dibujo restringida a 400x400 píxeles.
- Coordenadas válidas en el rango [0, 399].
- Solo se soporta un color de relleno (negro).

## 👤 Autor
*Julio Enrique Viche Castillo*