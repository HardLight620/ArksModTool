INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public ToggleLOD
public ToggleLOD_End
public ToggleLOD_Bindings

.DATA

ToggleLOD_Bindings	DWORD		0
bind0				DWORD		b0+2
bind1				DWORD		b1+1

.CODE

ToggleLOD:
	movss xmm0, [esi+000000CC]
b0:	test byte ptr ds:[NO_ADDRESS], FLAG1_DISABLE_LOD_REDUCTION
	je d0
	pxor xmm0, xmm0
b1:
d0:	jmp NO_SYMBOL
ToggleLOD_End:

END