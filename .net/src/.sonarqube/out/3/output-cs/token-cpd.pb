˝
jC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Data\Repositories\Base\BaseRepository.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Data 
. 
Repositories +
.+ ,
Base, 0
{ 
public 

abstract 
class 
BaseRepository (
<( )
TEntity) 0
,0 1
Tid2 5
>5 6
:		 	
IBaseRepository		
 
<		 
TEntity		 !
,		! "
Tid		# &
>		& '
where		( -
TEntity		. 5
:		6 7

BaseEntity		8 B
<		B C
Tid		C F
>		F G
{ 
private 
readonly 
IMongoCollection )
<) *
TEntity* 1
>1 2
_collection3 >
;> ?
public 
virtual 
async 
Task !
<! "
TEntity" )
>) *
Add+ .
(. /
TEntity/ 6
entity7 =
)= >
{ 	
await 
_collection 
. 
InsertOneAsync ,
(, -
entity- 3
)3 4
;4 5
return 
entity 
; 
} 	
public 
virtual 
async 
Task !
<! "
TEntity" )
>) *
FindById+ 3
(3 4
Tid4 7
Id8 :
): ;
{ 	
throw 
new 
System 
. #
NotImplementedException 4
(4 5
)5 6
;6 7
} 	
} 
} ≥
rC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Data\Repositories\Base\MongoDB\MongoDBContext.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Data 
. 
Repositories +
.+ ,
Base, 0
.0 1
MongoDB1 8
{ 
public 

class 
MongoDBContext 
:  !
IMongoDBContext" 1
{ 
private 
readonly 
IMongoDatabase '
_mongoDatabase( 6
;6 7
public

 
MongoDBContext

 
(

 
)

 
{ 	
MongoClientSettings 
mongoClientSettings  3
=4 5
MongoClientSettings6 I
. 
FromUrl 
( 
new 
MongoUrl %
(% &
$str& (
)( )
)) *
;* +
mongoClientSettings 
.  
SslSettings  +
=, -
new 
SslSettings 
(  
)  !
{ 
EnabledSslProtocols '
=( )
System* 0
.0 1
Security1 9
.9 :
Authentication: H
.H I
SslProtocolsI U
.U V
Tls12V [
} 
; 
MongoClient 
mongoClient #
=$ %
new& )
MongoClient* 5
(5 6
settings6 >
:> ?
mongoClientSettings@ S
)S T
;T U
_mongoDatabase 
= 
mongoClient (
.( )
GetDatabase) 4
(4 5
$str5 7
)7 8
;8 9
} 	
public 
IMongoCollection 
<  
TEntity  '
>' (
GetCollection) 6
<6 7
TEntity7 >
>> ?
(? @
string@ F

collectionG Q
)Q R
{ 	
return 
_mongoDatabase !
.! "
GetCollection" /
</ 0
TEntity0 7
>7 8
(8 9
name9 =
:= >

collection? I
)I J
;J K
} 	
} 
} ±
zC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Data\Repositories\EmployeeRole\EmployeeRoleRepository.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Data 
. 
Repositories +
.+ ,
EmployeeRole, 8
{ 
public 

class "
EmployeeRoleRepository '
:( )
BaseRepository* 8
<8 9
Projeto9 @
.@ A
DomainA G
.G H

AggregatesH R
.R S
EmployeeRoleS _
._ `
Entities` h
.h i
EmployeeRolei u
,u v
stringw }
>} ~
,		 	#
IEmployeeRoleRepository		
 !
{

 
public 
override 
Task 
< 
Projeto $
.$ %
Domain% +
.+ ,

Aggregates, 6
.6 7
EmployeeRole7 C
.C D
EntitiesD L
.L M
EmployeeRoleM Y
>Y Z
Add[ ^
(^ _
Projeto_ f
.f g
Domaing m
.m n

Aggregatesn x
.x y
EmployeeRole	y Ö
.
Ö Ü
Entities
Ü é
.
é è
EmployeeRole
è õ
entity
ú ¢
)
¢ £
{ 	
return 
base 
. 
Add 
( 
entity "
)" #
;# $
} 	
} 
} ö
rC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Data\Repositories\Employee\EmployeeRepository.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Data 
. 
Repositories +
.+ ,
Employee, 4
{ 
public 

class 
EmployeeRepository #
:$ %
BaseRepository 
< 
Projeto 
. 
Domain %
.% &

Aggregates& 0
.0 1
Employee1 9
.9 :
Entities: B
.B C
EmployeeC K
,K L
stringM S
>S T
, 	
IEmployeeRepository	 
{		 
} 
} 