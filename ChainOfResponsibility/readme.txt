What Is This Pattern?
The Chain of Responsibility design pattern seeks to avoid coupling a request to a particular
receiver by giving more than one object a chance to handle a particular request.
In essence, we pass an object along a "chain" of potential handlers for that object until one of
the handlers deals with the request.

The Participants
• The Handler defines an interface for handling requests.
• The ConcreteHandler objects can each handle a request, and can access their successor object.
• The Client initiates the request to a ConcreteHandler object.