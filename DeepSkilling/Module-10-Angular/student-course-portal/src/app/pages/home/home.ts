import {
  Component,
  OnInit,
  OnChanges,
  OnDestroy,
  SimpleChanges
} from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    CourseCard
  ],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnChanges, OnDestroy {

  // ---------------------------
  // Portal Information
  // ---------------------------

  portalName = 'Student Course Portal';

  today = new Date();

  message = '';

  searchTerm = '';

  isPortalActive = true;

  selectedCourse = 'Angular Fundamentals';

  // ---------------------------
  // Course List
  // ---------------------------

  courses = [
    {
      id: 1,
      name: 'Angular Fundamentals',
      credits: 4,
      fee: 3500,
      available: true
    },
    {
      id: 2,
      name: 'React Basics',
      credits: 3,
      fee: 2800,
      available: true
    },
    {
      id: 3,
      name: 'Node.js',
      credits: 4,
      fee: 4200,
      available: false
    }
  ];

  // ---------------------------
  // Template Driven Form
  // ---------------------------

  studentName = '';

  studentEmail = '';

  courseId = '';

  agreeToTerms = false;

  submitted = false;

  // ---------------------------
  // Constructor
  // ---------------------------

  constructor() {
    console.log('Constructor');
  }

  // ---------------------------
  // Lifecycle Hooks
  // ---------------------------

  ngOnInit(): void {
    console.log('ngOnInit');
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
  }

  ngOnDestroy(): void {
    console.log('Component Destroyed');
  }

  // ---------------------------
  // Existing Methods
  // ---------------------------

  onEnrollClick(): void {
    this.message = 'Enrollment opened!';
  }

  onCourseEnroll(): void {
    alert('Successfully enrolled!');
  }

  // ---------------------------
  // Template Driven Form Submit
  // ---------------------------

  onSubmit(form: NgForm): void {

    console.log('Form Value');

    console.log(form.value);

    console.log('Form Valid');

    console.log(form.valid);

    this.submitted = true;

  }

  // ---------------------------
  // Reset Form
  // ---------------------------

  resetForm(form: NgForm): void {

    form.resetForm();

    this.submitted = false;

  }

}