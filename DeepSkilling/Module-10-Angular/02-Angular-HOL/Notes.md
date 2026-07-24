# Angular Hands-On 2 Notes

## Interpolation

Displays TypeScript variables inside HTML using double curly braces.

Example:

{{ portalName }}

---

## Property Binding

Binds a TypeScript property to an HTML property.

Example:

[disabled]="!isPortalActive"

---

## Event Binding

Executes a TypeScript method when an event occurs.

Example:

(click)="onEnrollClick()"

---

## Two-Way Binding

Synchronizes data between the template and the component.

Requires FormsModule.

Example:

[(ngModel)]="searchTerm"

---

## Lifecycle Hooks

### ngOnInit()

Executed once after component initialization.

---

### ngOnChanges()

Executed whenever an @Input property changes.

---

### ngOnDestroy()

Executed before the component is destroyed.

Useful for cleanup.

---

## @Input

Receives data from the parent component.

Example:

@Input()
courseName = '';

---

## @Output

Sends events from child to parent.

Uses EventEmitter.

Example:

@Output()
enroll = new EventEmitter<void>();

---

## EventEmitter

Used to emit custom events.

Example:

this.enroll.emit();

---

## Parent Child Communication

Parent passes data using @Input.

Child notifies parent using @Output.

---

## Learning Outcome

Learned Angular data binding, lifecycle hooks, FormsModule, and communication between components using @Input and @Output.