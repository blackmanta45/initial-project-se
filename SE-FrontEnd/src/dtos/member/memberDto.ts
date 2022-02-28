export interface MemberDto {
    id: string;
    name: string;
    age: number;
    spendingLimit: number;
    cnp: string;
    createdAt: string;
    modifiedAt: string;
    isEdit: boolean;
    isSelected: boolean;
}

export const UserSchema = {
    isSelected: "isSelected",
    name: "text",
    age: "text",
    spendingLimit: "text",
    cnp:"text",
    isEdit: "isEdit"
}