.data
    a dd 5
    b dd 10
    c dd 56

.code
main proc
    mov eax, c
    cdq
    mov ebx, 28
    idiv ebx
    add eax, b
    sub eax, 1
    mov ecx, eax

    mov eax, 4
    imul b
    mov ebx, eax

    mov eax, c
    imul a
    sub ebx, eax

    mov eax, ebx
    cdq
    idiv ecx

    ret
main endp
end