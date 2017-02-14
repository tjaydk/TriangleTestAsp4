# TriangleTestAsp4
####Version two after refactore. Link to original repo: https://github.com/tjaydk/TriangleTest

Here is a screendump of the code analysis metrics
![alt tag](https://github.com/tjaydk/TriangleTestAsp4/blob/master/CodeAnalysisMetrics.JPG)

This is review for Ebbe's program. (It is written in danish)

- Ville forslå at der kun er en public metode der bliver kaldt da resten er afhængige og derfor bør være private.
- Fjern input fra triangle klassen så inputs ligger i en seperat klasse.
- XMLDoc til metoder
- Ved multicase if statement læg de forskellige cases på ny linje for læsbarhed.
- Fjern unødvendige klasse dependencies
- Mulighed for at kører program igen uden at skulle genstarte
- Vælg om du sætter if statements på en linje eller flere

List of coding standard for team C#:
- Use XML Docs on all public methods
- Use indent to have staments parameters and declarations to be lined up under each other
- statements with long multiple conditions broken down to different lines and lined up
- method and variable names should be humanly readable
- remove unused using dependencies from classes
- global variables should be declared in beginning of class file
- local variables should be declared in the beginning of methods
