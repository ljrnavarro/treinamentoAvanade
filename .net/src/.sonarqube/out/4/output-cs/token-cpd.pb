¯
tC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Projeto.Api\Controllers\EmployeeRoleControllers.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Projeto !
.! "
Api" %
.% &
Controllers& 1
{		 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 

ApiVersion 
( 
$str 
, 

Deprecated 
=  !
false" '
)' (
]( )
[ 
ApiController 
] 
[ 
ApiExplorerSettings 
( 
	GroupName "
=# $
$str% )
)) *
]* +
public 

class #
EmployeeRoleControllers (
:) *
ControllerBase+ 9
{ 
[ 	
HttpPost	 
( 
Name 
= 
$str '
)' (
]( )
[ 	
Consumes	 
( 
MediaTypeNames  
.  !
Application! ,
., -
Json- 1
)1 2
]2 3
[ 	 
ProducesResponseType	 
( 
typeof $
($ %
EmployeeRoleDto% 4
)4 5
,5 6
StatusCodes7 B
.B C
Status201CreatedC S
)S T
]T U
[ 	 
ProducesResponseType	 
( 
StatusCodes )
.) *(
Status500InternalServerError* F
)F G
]G H
public 
async 
Task 
< 
IActionResult '
>' (
CreateEmployeeRole) ;
(; <
[< =
FromBody= E
]E F
EmployeeRoleDtoG V
employeeRoleDtoW f
)f g
{ 	"
EmployeeRoleAppService ""
employeeRoleAppService# 9
=: ;
new< ?"
EmployeeRoleAppService@ V
(V W
)W X
;X Y
var 
item 
= 
await "
employeeRoleAppService 3
.3 4 
AddEmployeeRoleAsync4 H
(H I
employeeRoleDtoI X
)X Y
;Y Z
if 
( 
! 
item 
. 
validationResult &
.& '
IsValid' .
). /
{ 

BadRequest 
( 
string !
.! "
Join" &
(& '
$char' +
,+ ,
item- 1
.1 2
validationResult2 B
.B C
ErrorsC I
)I J
)J K
;K L
} 
return 
Ok 
( 
) 
; 
}   	
}!! 
}"" •
XC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Projeto.Api\Program.cs
	namespace

 	
Avanade


 
.

 
SubTCSE

 
.

 
Projeto

 !
.

! "
Api

" %
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} °!
XC:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Projeto.Api\Startup.cs
	namespace

 	
Avanade


 
.

 
SubTCSE

 
.

 
Projeto

 !
.

! "
Api

" %
{ 
public 

class 
Startup 
{ 
public 
IConfiguration 
_configuration ,
{- .
get/ 2
;2 3
}4 5
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
_configuration 
= 
configuration *
;* +
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
;% &
services 
. 
AddApiVersioning %
(% &
options 
=> 
{ 
options   
.   
ReportApiVersions   -
=  . /
true  0 4
;  4 5
options!! 
.!! /
#AssumeDefaultVersionWhenUnspecified!! ?
=!!@ A
true!!B F
;!!F G
options"" 
."" 
DefaultApiVersion"" -
="". /
new""0 3

ApiVersion""4 >
(""> ?
$num""? @
,""@ A
$num""B C
)""C D
;""D E
}## 
)## 
.$$ #
AddVersionedApiExplorer$$ (
($$( )
options$$) 0
=>$$1 3
{%% 
options&& 
.&& 
GroupNameFormat&& +
=&&, -
$str&&. 6
;&&6 7
options'' 
.'' %
SubstituteApiVersionInUrl'' 5
=''6 7
true''8 <
;''< =
}(( 
)(( 
.)) 
AddSwaggerGen)) 
()) 
c))  
=>))! #
{** 
c++ 
.++ 

SwaggerDoc++  
(++  !
$str++! %
,++% &
new++' *
OpenApiInfo+++ 6
{++7 8
Title++9 >
=++? @
$str++A ^
,++^ _
Version++` g
=++h i
$str++j n
}++o p
)++p q
;++q r
},, 
),, 
;,, 
services.. 
... -
!AddRegisterDependenciesInjections.. 6
(..6 7
)..7 8
;..8 9
}00 	
public33 
void33 
	Configure33 
(33 
IApplicationBuilder33 1
app332 5
,335 6
IWebHostEnvironment337 J
env33K N
)33N O
{44 	
if55 
(55 
env55 
.55 
IsDevelopment55 !
(55! "
)55" #
)55# $
{66 
app77 
.77 %
UseDeveloperExceptionPage77 -
(77- .
)77. /
;77/ 0
app88 
.88 

UseSwagger88 
(88 
)88  
;88  !
app99 
.99 
UseSwaggerUI99  
(99  !
c99! "
=>99# %
c99& '
.99' (
SwaggerEndpoint99( 7
(997 8
$str998 R
,99R S
$str99T t
)99t u
)99u v
;99v w
}:: 
app<< 
.<< 
UseHttpsRedirection<< #
(<<# $
)<<$ %
;<<% &
app>> 
.>> 

UseRouting>> 
(>> 
)>> 
;>> 
app@@ 
.@@ 
UseAuthorization@@  
(@@  !
)@@! "
;@@" #
appBB 
.BB 
UseEndpointsBB 
(BB 
	endpointsBB &
=>BB' )
{CC 
	endpointsDD 
.DD 
MapControllersDD (
(DD( )
)DD) *
;DD* +
}EE 
)EE 
;EE 
}FF 	
}GG 
}HH É
`C:\CursosTreinamentos\treinamentoAvanade\.net\src\Avanade.SubTCSE.Projeto.Api\WeatherForecast.cs
	namespace 	
Avanade
 
. 
SubTCSE 
. 
Projeto !
.! "
Api" %
{ 
public 

class 
WeatherForecast  
{ 
public 
DateTime 
Date 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
int		 
TemperatureC		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public 
int 
TemperatureF 
=>  "
$num# %
+& '
(( )
int) ,
), -
(- .
TemperatureC. :
/; <
$num= C
)C D
;D E
public 
string 
Summary 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} 