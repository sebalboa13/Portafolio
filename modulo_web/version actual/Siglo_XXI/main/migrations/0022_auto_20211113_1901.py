# Generated by Django 3.1.3 on 2021-11-13 22:01

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0021_auto_20211112_1644'),
    ]

    operations = [
        migrations.AlterField(
            model_name='tipoproductoxxi',
            name='tipo_producto',
            field=models.CharField(max_length=50),
        ),
    ]
