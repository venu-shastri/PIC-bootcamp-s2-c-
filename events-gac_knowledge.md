# Event Driven Programming

> Event - Consequence of Action , State 
>
> EventSource  - Event - EventSink 
>
> Notification Program 
>
> Observable Pattern - How to make an object Observable ( state change can be notified )
>
> Event Driven Prgoramming using C#
>
> - How to Declare Event - define variable  of delegate type , register Event Mutators (Add,Remove)
>   - public **event** <DelegateName> <EventName>
> - How to Publish Event - Call Invoke() on delegate object [Note: check for event nullabality]
> - How to Subscribe for Event - Call Add_'EventName' (delegate Instance)
>   - <EventName>+= <delegateInstance>
> - How to UnSubscribe - Call Remove_EventName(delegateInstance)
>   - <EventName>-=<delegateInstance>
>
> TV - Operating Time > 4 hours 
>
> Display -> Popoup Message 
>
> Temperature Monitoring Device 
>
> Coolant Engine
>
> Vehicle Auto AC 
>
> Zoom Car 



## Built in Deleagtes

- Func
  - <returnType>(0-16 Different Parameters)
  - Func<T1.................T16,ReturnType> 
- Action 
  - void(0-16 Different Parameters )
  - Action<T1........T16> 

### Keywords

- ref
- out
- params
- is
- as
- var 
- sealed
- delegate
- event
- enum
- class
- struct
- static 
- interface
- abstarct
- virtual
- override
- namespace
- using 
- get ,set 

### GAC

> Global Assembly Cache 
>
> Location : ![image-20200910120528968](D:\knowledge\pic-s2.2\image-20200910120528968.png)
>
> Use **gacutil.exe** - Add/remove Assembly From the GAC
>
> GAC Membership Condition : Assembly must have strong identity (Strong Name) 
>
> Why GAC require Strong Name for the Assembly?
>
> 
>
> PICWord.exe
>
> PICPowerPoint.exe
>
> PICExcel.exe
>
> SpellCheker.dll
>
> -  SpellChecker -> D:\knowledge\S2-Bootcamp-PIC\SpellChecker\bin\Debug\1.0.0.0\SpellChecker.dll
> - ![image-20200910120915100](C:\Users\user\AppData\Roaming\Typora\typora-user-images\image-20200910120915100.png)



C# Project Build -> Output -> Assembly File (.exe/ .dll)

> Assembly Identity :
>
> "Name,Version=Major.Minor.Build.Revision,PublicKey=Vaue,Culture=Value"
>
> Classification of Assembly Identity
>
> - Weak Identity : Identity Without Public Key (Unsigned Assembly )
> - Strong Identity : Identity With Public key (Signed Assembly)
>
> How to Sign Assembly and Why ?



Go To Properties of Project and Select Signing Tab

![image-20200910122202441](D:\knowledge\pic-s2.2\image-20200910122202441.png)



Assembly Identity of Signed Assembly

![image-20200910122356034](D:\knowledge\pic-s2.2\AssemblyIdentity)



Last Day Notes:

![GAC_Doc](D:\knowledge\pic-s2.2\GAC_Doc.png)