export interface Org {
    id: number;
    sourcedId: string;
    status: string;
    dateLastModified: Date;
    name: string;
    type: string;
    parentSourcedId: string;
}
