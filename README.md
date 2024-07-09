# Final_Project_Pt3

Este es el repositorio donde se encuentra la API que consume el paquete NuGet de el primer repositorio del proyecto final.

Para descargar la imagen, utilizar este comando:

    docker pull azriel720/myapp

Luego de instalada la imagen, correr el contenedor con este comando:

    docker run -d -p 8080:8080 azriel720/myapp

El formato de entrada para que funcione correctamente puede ser de este manera:

    http://localhost:8080/SixLetterWords?input=co%2Cmoss%2Ccomoss

Palabra 1 = co

Palabra 2 = moss

Palabra 3 = comoss

Resultado esperado: comoss
