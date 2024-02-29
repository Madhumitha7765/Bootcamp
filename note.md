## Techs
narrative, feature, scenario, steps
specflow in .net
cypress in react
learn hot to write specs - Gherkin(cucumber) - talks about narrative - As a _ what i do format
each scenario has 3 steps - given, when, then
follow c4model

## JS
1. Constructor(is a function, applied using new binding) - pascalcase, no return statement
> var obj = {} is eq. to var obj = new Object();
2. Functions : function object - camel case
> function test (){} is eq to var func = new Function(arg, fucn body)  
3. Every js object is treenode : with key,values
4. Object has a attribute : _proto_ - object prototype has key value pairs, global and common to all obejcts created in appl.
5. Only has a relationship
6. Built in constructor has defineproperty call - used to add Configuration to property object(metadata), get/set for the object. 
   Other way : indexing or assigning
   > obj.key = "value" or obj["key"] = value 

  https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/defineProperty

7. In case obj doesnt have a key, but defined by user, key value pair required is created only if object is "Mutable"
   Explicitly can make an object immutable (Object.freeze())

![image](https://github.com/Madhumitha7765/Bootcamp/assets/68181437/a1483672-7654-404e-8177-0b7e7e08d4e2)


### Function Object

1. Func with prototype col : function object
2. FUnc with __proto__
3. func without __proto__ : execution context obj

Every func obj had 2 diff memeory blocks - say for function test 
- 2 blocks - test, test.prototype
- test - has prototype col -> __proto__ points to function constructor which in turn points to object prototype
- test.prototype - __proto__ has val pointing to obj.protoype
- object.prototype - root, __proto__.value = null

## Applying function 
- uses binding
- 2 pass execution(compilation, execution) every func visited twice
- 1st pass - function is visited by compiler line by line, object created on memory(only obj to not have __proto__) and is called execution context obj(local scope)
- Execution context obj has special key apart from args,values - "this" : a property created in local scope for function execution
- this purpose : passing context info from caller to callee.
- Binding - process to provide value for this attribute inside execution context obj when function is called


### Function Binding
| https://charandev.com/understanding-javascript-this-or-different-runtime-binding-techniques#heading-1-default-binding-direct-invocation
- Default binding 
| test(); - creates this value with global scope
if JS code is executed in browser - its called window obj
- Explicit Binding : used if this value must be custom, implemented using cal,apply
| test.apply(100) : sets this to 100 in execution context obj.

### New binding

```js
function Student(rollnum) {
  this._rollNumber = rollnum;
  this.getRollNumber = function() {
    return this._rollNumber;
 / }
}

var temp = new Student(20);
console.log(temp.getRollNumber());
```
> new - creates empty object
> constructor populates data in the obj created


## Typescript - JS transpiler

# UI

## Types 
4 forms 
- Rich : Access all resources of OS, its a Desktop UI. eg: visual studio
- Reachable
- Rich internet application UI - develop rich content, use web plugins to make it reachable
- hybrid UI
- Other techniques - headless UI, micro frontends
- Progressive web apps - app like web behaviour

## Browser working

- The Critical Rendering Path :  sequence of steps the browser goes through to convert the HTML, CSS, and JavaScript into pixels on the screen
- DOM : https://dev.to/coderedjack/critical-rendering-path-web-performance-23ij
https://www.google.com/url?sa=i&url=https%3A%2F%2Fguillermo.at%2Fbrowser-critical-render-path&psig=AOvVaw2jODxWuU3_AikSwin5B2yR&ust=1709283458526000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCNirwaKX0IQDFQAAAAAdAAAAABAU
- Composite UI - one dom tree for entire applicaition(Single page appl. SPA)

## React
- VDOM tree
- for dynamic apps

## Angular 
- No VDOM but similar concept implemented

> refer JAM stack
> web assemblies
> blazer





