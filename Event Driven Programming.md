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

